// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;
using Xunit;

public class ConvertToDateTimeTests : ConvertTestBase<DateTime>
{
    private static readonly DateTimeFormatInfo s_dateTimeFormatInfo = new DateTimeFormatInfo();

    [Fact]
    public void FromString()
    {
        DateTime[] expectedValues = { new DateTime(1999, 12, 31, 23, 59, 59), new DateTime(100, 1, 1, 0, 0, 0), new DateTime(2216, 2, 29, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0) };

        // Generate test values. Note that some calendars have very restricted date ranges.
        var dateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
        if (expectedValues[1] < dateTimeFormat.Calendar.MinSupportedDateTime)
            expectedValues[1] = dateTimeFormat.Calendar.MinSupportedDateTime.AddYears(100);
        if (expectedValues[2] > dateTimeFormat.Calendar.MaxSupportedDateTime)
            expectedValues[2] = dateTimeFormat.Calendar.MaxSupportedDateTime.Date;
        if (expectedValues[3] < dateTimeFormat.Calendar.MinSupportedDateTime)
            expectedValues[3] = dateTimeFormat.Calendar.MinSupportedDateTime;

        string pattern = dateTimeFormat.LongDatePattern + ' ' + dateTimeFormat.LongTimePattern;
        String[] testValues = new String[expectedValues.Length];
        for (int i = 0; i < expectedValues.Length; i++)
        {
            testValues[i] = expectedValues[i].ToString(pattern, dateTimeFormat);
        }

        VerifyFromString(Convert.ToDateTime, Convert.ToDateTime, testValues, expectedValues);
        VerifyFromObject(Convert.ToDateTime, Convert.ToDateTime, testValues, expectedValues);

        String[] formatExceptionValues =
        {
            "null",
            // Regression test for case which was throwing IndexOutOfRangeException
            "20-5-14T00:00:00"
        };

        VerifyFromStringThrows<FormatException>(Convert.ToDateTime, Convert.ToDateTime, formatExceptionValues);
    }

    [Fact]
    public void FromStringWithCustomFormatProvider()
    {
        String[] testValues = { null, "12/31/1999 11:59:59 PM", "0100/01/01 12:00:00 AM", "1492/02/29 12:00:00 AM", "0001/01/01 12:00:00 AM" };
        DateTime[] expectedValues = { DateTime.MinValue, new DateTime(1999, 12, 31, 23, 59, 59), new DateTime(100, 1, 1, 0, 0, 0), new DateTime(1492, 2, 29, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0) };
        Assert.Equal(testValues.Length, expectedValues.Length);

        for (int i = 0; i < testValues.Length; i++)
        {
            DateTime result = Convert.ToDateTime(testValues[i], s_dateTimeFormatInfo);
            Assert.Equal(expectedValues[i], result);
            result = Convert.ToDateTime((object)testValues[i], s_dateTimeFormatInfo);
            Assert.Equal(expectedValues[i], result);
        }
    }

    [Fact]
    public void FromDateTime()
    {
        DateTime[] expectedValues = { new DateTime(1999, 12, 31, 23, 59, 59), new DateTime(100, 1, 1, 0, 0, 0), new DateTime(1492, 2, 29, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0) };
        for (int i = 0; i < expectedValues.Length; i++)
        {
            DateTime result = Convert.ToDateTime(expectedValues[i]);
            Assert.Equal(expectedValues[i], result);
        }
    }

    [Fact]
    public void FromObject()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(new Object()));
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(new Object(), s_dateTimeFormatInfo));
    }

    [Fact]
    public void FromBoolean()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(false));
    }

    [Fact]
    public void FromChar()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime('a'));
    }

    [Fact]
    public void FromInt16()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime((Int16)5));
    }

    [Fact]
    public void FromInt32()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(6));
    }

    [Fact]
    public void FromInt64()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime((Int64)5));
    }

    [Fact]
    public void FromUInt16()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime((UInt16)5));
    }

    [Fact]
    public void FromUInt32()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime((UInt32)5));
    }

    [Fact]
    public void FromUInt64()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime((UInt64)5));
    }

    [Fact]
    public void FromSingle()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(1.0f));
    }

    [Fact]
    public void FromDouble()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(1.1));
    }

    [Fact]
    public void FromDecimal()
    {
        Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(1.0m));
    }
}
