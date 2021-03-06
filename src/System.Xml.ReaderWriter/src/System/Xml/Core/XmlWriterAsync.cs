// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading.Tasks;

using System;
using System.IO;
using System.Text;
using System.Xml.Schema;
using System.Diagnostics;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Versioning;

namespace System.Xml
{
    // Represents a writer that provides fast non-cached forward-only way of generating XML streams containing XML documents 
    // that conform to the W3C Extensible Markup Language (XML) 1.0 specification and the Namespaces in XML specification.
    public abstract partial class XmlWriter : IDisposable
    {
        // Write methods
        // Writes out the XML declaration with the version "1.0".

        public virtual Task WriteStartDocumentAsync()
        {
            throw NotImplemented.ByDesign;
        }

        //Writes out the XML declaration with the version "1.0" and the speficied standalone attribute.

        public virtual Task WriteStartDocumentAsync(bool standalone)
        {
            throw NotImplemented.ByDesign;
        }

        //Closes any open elements or attributes and puts the writer back in the Start state.

        public virtual Task WriteEndDocumentAsync()
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out the DOCTYPE declaration with the specified name and optional attributes.

        public virtual Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset)
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out the specified start tag and associates it with the given namespace and prefix.

        public virtual Task WriteStartElementAsync(string prefix, string localName, string ns)
        {
            throw NotImplemented.ByDesign;
        }

        // Closes one element and pops the corresponding namespace scope.

        public virtual Task WriteEndElementAsync()
        {
            throw NotImplemented.ByDesign;
        }

        // Closes one element and pops the corresponding namespace scope. Writes out a full end element tag, e.g. </element>.

        public virtual Task WriteFullEndElementAsync()
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out the attribute with the specified LocalName, value, and NamespaceURI.
        // Writes out the attribute with the specified prefix, LocalName, NamespaceURI and value.
        public Task WriteAttributeStringAsync(string prefix, string localName, string ns, string value)
        {
            Task task = WriteStartAttributeAsync(prefix, localName, ns);
            if (task.IsSuccess())
            {
                return WriteStringAsync(value).CallTaskFuncWhenFinishAsync(thisRef => thisRef.WriteEndAttributeAsync(), this);
            }
            else
            {
                return WriteAttributeStringAsyncHelper(task, value);
            }
        }

        private async Task WriteAttributeStringAsyncHelper(Task task, string value)
        {
            await task.ConfigureAwait(false);
            await WriteStringAsync(value).ConfigureAwait(false);
            await WriteEndAttributeAsync().ConfigureAwait(false);
        }

        // Writes the start of an attribute.

        protected internal virtual Task WriteStartAttributeAsync(string prefix, string localName, string ns)
        {
            throw NotImplemented.ByDesign;
        }

        // Closes the attribute opened by WriteStartAttribute call.

        protected internal virtual Task WriteEndAttributeAsync()
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out a <![CDATA[...]]>; block containing the specified text.

        public virtual Task WriteCDataAsync(string text)
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out a comment <!--...-->; containing the specified text.

        public virtual Task WriteCommentAsync(string text)
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out a processing instruction with a space between the name and text as follows: <?name text?>

        public virtual Task WriteProcessingInstructionAsync(string name, string text)
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out an entity reference as follows: "&"+name+";".

        public virtual Task WriteEntityRefAsync(string name)
        {
            throw NotImplemented.ByDesign;
        }

        // Forces the generation of a character entity for the specified Unicode character value.

        public virtual Task WriteCharEntityAsync(char ch)
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out the given whitespace.

        public virtual Task WriteWhitespaceAsync(string ws)
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out the specified text content.

        public virtual Task WriteStringAsync(string text)
        {
            throw NotImplemented.ByDesign;
        }

        // Write out the given surrogate pair as an entity reference.

        public virtual Task WriteSurrogateCharEntityAsync(char lowChar, char highChar)
        {
            throw NotImplemented.ByDesign;
        }

        // Writes out the specified text content.

        public virtual Task WriteCharsAsync(char[] buffer, int index, int count)
        {
            throw NotImplemented.ByDesign;
        }

        // Writes raw markup from the given character buffer.

        public virtual Task WriteRawAsync(char[] buffer, int index, int count)
        {
            throw NotImplemented.ByDesign;
        }

        // Writes raw markup from the given string.

        public virtual Task WriteRawAsync(string data)
        {
            throw NotImplemented.ByDesign;
        }

        // Encodes the specified binary bytes as base64 and writes out the resulting text.

        public virtual Task WriteBase64Async(byte[] buffer, int index, int count)
        {
            throw NotImplemented.ByDesign;
        }

        // Encodes the specified binary bytes as binhex and writes out the resulting text.
        public virtual Task WriteBinHexAsync(byte[] buffer, int index, int count)
        {
            return BinHexEncoder.EncodeAsync(buffer, index, count, this);
        }

        // Flushes data that is in the internal buffers into the underlying streams/TextReader and flushes the stream/TextReader.

        public virtual Task FlushAsync()
        {
            throw NotImplemented.ByDesign;
        }

        // Scalar Value Methods

        // Writes out the specified name, ensuring it is a valid NmToken according to the XML specification 
        // (http://www.w3.org/TR/1998/REC-xml-19980210#NT-Name).
        public virtual Task WriteNmTokenAsync(string name)
        {
            if (name == null || name.Length == 0)
            {
                throw new ArgumentException(SR.Xml_EmptyName);
            }
            return WriteStringAsync(XmlConvert.VerifyNMTOKEN(name, ExceptionType.ArgumentException));
        }

        // Writes out the specified name, ensuring it is a valid Name according to the XML specification
        // (http://www.w3.org/TR/1998/REC-xml-19980210#NT-Name).
        public virtual Task WriteNameAsync(string name)
        {
            return WriteStringAsync(XmlConvert.VerifyQName(name, ExceptionType.ArgumentException));
        }

        // Writes out the specified namespace-qualified name by looking up the prefix that is in scope for the given namespace.
        public virtual async Task WriteQualifiedNameAsync(string localName, string ns)
        {
            if (ns != null && ns.Length > 0)
            {
                string prefix = LookupPrefix(ns);
                if (prefix == null)
                {
                    throw new ArgumentException(SR.Format(SR.Xml_UndefNamespace, ns));
                }
                await WriteStringAsync(prefix).ConfigureAwait(false);
                await WriteStringAsync(":").ConfigureAwait(false);
            }
            await WriteStringAsync(localName).ConfigureAwait(false);
        }

        // XmlReader Helper Methods

        // Writes out all the attributes found at the current position in the specified XmlReader.
        public virtual async Task WriteAttributesAsync(XmlReader reader, bool defattr)
        {
            if (null == reader)
            {
                throw new ArgumentNullException("reader");
            }

            if (reader.NodeType == XmlNodeType.Element || reader.NodeType == XmlNodeType.XmlDeclaration)
            {
                if (reader.MoveToFirstAttribute())
                {
                    await WriteAttributesAsync(reader, defattr).ConfigureAwait(false);
                    reader.MoveToElement();
                }
            }
            else if (reader.NodeType != XmlNodeType.Attribute)
            {
                throw new XmlException(SR.Xml_InvalidPosition, string.Empty);
            }
            else
            {
                do
                {
                    // we need to check both XmlReader.IsDefault and XmlReader.SchemaInfo.IsDefault. 
                    // If either of these is true and defattr=false, we should not write the attribute out
                    if (defattr || !reader.IsDefaultInternal)
                    {
                        await WriteStartAttributeAsync(reader.Prefix, reader.LocalName, reader.NamespaceURI).ConfigureAwait(false);
                        while (reader.ReadAttributeValue())
                        {
                            if (reader.NodeType == XmlNodeType.EntityReference)
                            {
                                await WriteEntityRefAsync(reader.Name).ConfigureAwait(false);
                            }
                            else
                            {
                                await WriteStringAsync(reader.Value).ConfigureAwait(false);
                            }
                        }
                        await WriteEndAttributeAsync().ConfigureAwait(false);
                    }
                }
                while (reader.MoveToNextAttribute());
            }
        }

        // Copies the current node from the given reader to the writer (including child nodes), and if called on an element moves the XmlReader 
        // to the corresponding end element.
        public virtual Task WriteNodeAsync(XmlReader reader, bool defattr)
        {
            if (null == reader)
            {
                throw new ArgumentNullException("reader");
            }

            if (reader.Settings != null && reader.Settings.Async)
            {
                return WriteNodeAsync_CallAsyncReader(reader, defattr);
            }
            else
            {
                return WriteNodeAsync_CallSyncReader(reader, defattr);
            }
        }


        // Copies the current node from the given reader to the writer (including child nodes), and if called on an element moves the XmlReader 
        // to the corresponding end element.
        //use sync methods on the reader
        internal async Task WriteNodeAsync_CallSyncReader(XmlReader reader, bool defattr)
        {
            bool canReadChunk = reader.CanReadValueChunk;
            int d = reader.NodeType == XmlNodeType.None ? -1 : reader.Depth;
            do
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        await WriteStartElementAsync(reader.Prefix, reader.LocalName, reader.NamespaceURI).ConfigureAwait(false);
                        await WriteAttributesAsync(reader, defattr).ConfigureAwait(false);
                        if (reader.IsEmptyElement)
                        {
                            await WriteEndElementAsync().ConfigureAwait(false);
                            break;
                        }
                        break;
                    case XmlNodeType.Text:
                        if (canReadChunk)
                        {
                            if (_writeNodeBuffer == null)
                            {
                                _writeNodeBuffer = new char[WriteNodeBufferSize];
                            }
                            int read;
                            while ((read = reader.ReadValueChunk(_writeNodeBuffer, 0, WriteNodeBufferSize)) > 0)
                            {
                                await this.WriteCharsAsync(_writeNodeBuffer, 0, read).ConfigureAwait(false);
                            }
                        }
                        else
                        {
                            await WriteStringAsync(reader.Value).ConfigureAwait(false);
                        }
                        break;
                    case XmlNodeType.Whitespace:
                    case XmlNodeType.SignificantWhitespace:
                        await WriteWhitespaceAsync(reader.Value).ConfigureAwait(false);
                        break;
                    case XmlNodeType.CDATA:
                        await WriteCDataAsync(reader.Value).ConfigureAwait(false);
                        break;
                    case XmlNodeType.EntityReference:
                        await WriteEntityRefAsync(reader.Name).ConfigureAwait(false);
                        break;
                    case XmlNodeType.XmlDeclaration:
                    case XmlNodeType.ProcessingInstruction:
                        await WriteProcessingInstructionAsync(reader.Name, reader.Value).ConfigureAwait(false);
                        break;
                    case XmlNodeType.DocumentType:
                        await WriteDocTypeAsync(reader.Name, reader.GetAttribute("PUBLIC"), reader.GetAttribute("SYSTEM"), reader.Value).ConfigureAwait(false);
                        break;

                    case XmlNodeType.Comment:
                        await WriteCommentAsync(reader.Value).ConfigureAwait(false);
                        break;
                    case XmlNodeType.EndElement:
                        await WriteFullEndElementAsync().ConfigureAwait(false);
                        break;
                }
            } while (reader.Read() && (d < reader.Depth || (d == reader.Depth && reader.NodeType == XmlNodeType.EndElement)));
        }

        // Copies the current node from the given reader to the writer (including child nodes), and if called on an element moves the XmlReader 
        // to the corresponding end element.
        //use async methods on the reader
        internal async Task WriteNodeAsync_CallAsyncReader(XmlReader reader, bool defattr)
        {
            bool canReadChunk = reader.CanReadValueChunk;
            int d = reader.NodeType == XmlNodeType.None ? -1 : reader.Depth;
            do
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        await WriteStartElementAsync(reader.Prefix, reader.LocalName, reader.NamespaceURI).ConfigureAwait(false);
                        await WriteAttributesAsync(reader, defattr).ConfigureAwait(false);
                        if (reader.IsEmptyElement)
                        {
                            await WriteEndElementAsync().ConfigureAwait(false);
                            break;
                        }
                        break;
                    case XmlNodeType.Text:
                        if (canReadChunk)
                        {
                            if (_writeNodeBuffer == null)
                            {
                                _writeNodeBuffer = new char[WriteNodeBufferSize];
                            }
                            int read;
                            while ((read = await reader.ReadValueChunkAsync(_writeNodeBuffer, 0, WriteNodeBufferSize).ConfigureAwait(false)) > 0)
                            {
                                await this.WriteCharsAsync(_writeNodeBuffer, 0, read).ConfigureAwait(false);
                            }
                        }
                        else
                        {
                            //reader.Value may block on Text or WhiteSpace node, use GetValueAsync
                            await WriteStringAsync(await reader.GetValueAsync().ConfigureAwait(false)).ConfigureAwait(false);
                        }
                        break;
                    case XmlNodeType.Whitespace:
                    case XmlNodeType.SignificantWhitespace:
                        await WriteWhitespaceAsync(await reader.GetValueAsync().ConfigureAwait(false)).ConfigureAwait(false);
                        break;
                    case XmlNodeType.CDATA:
                        await WriteCDataAsync(reader.Value).ConfigureAwait(false);
                        break;
                    case XmlNodeType.EntityReference:
                        await WriteEntityRefAsync(reader.Name).ConfigureAwait(false);
                        break;
                    case XmlNodeType.XmlDeclaration:
                    case XmlNodeType.ProcessingInstruction:
                        await WriteProcessingInstructionAsync(reader.Name, reader.Value).ConfigureAwait(false);
                        break;
                    case XmlNodeType.DocumentType:
                        await WriteDocTypeAsync(reader.Name, reader.GetAttribute("PUBLIC"), reader.GetAttribute("SYSTEM"), reader.Value).ConfigureAwait(false);
                        break;

                    case XmlNodeType.Comment:
                        await WriteCommentAsync(reader.Value).ConfigureAwait(false);
                        break;
                    case XmlNodeType.EndElement:
                        await WriteFullEndElementAsync().ConfigureAwait(false);
                        break;
                }
            } while (await reader.ReadAsync().ConfigureAwait(false) && (d < reader.Depth || (d == reader.Depth && reader.NodeType == XmlNodeType.EndElement)));
        }


        // Element Helper Methods

        // Writes out an attribute with the specified name, namespace URI, and string value.
        public async Task WriteElementStringAsync(string prefix, String localName, String ns, String value)
        {
            await WriteStartElementAsync(prefix, localName, ns).ConfigureAwait(false);
            if (null != value && 0 != value.Length)
            {
                await WriteStringAsync(value).ConfigureAwait(false);
            }
            await WriteEndElementAsync().ConfigureAwait(false);
        }
    }
}

