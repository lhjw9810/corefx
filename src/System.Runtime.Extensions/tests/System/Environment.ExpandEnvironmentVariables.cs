// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Text;
using System.Runtime.InteropServices;
using Xunit;

public class ExpandEnvironmentVariables
{
    [Fact]
    public void NullArgumentThrowsArgumentNull()
    {
        Assert.Throws<ArgumentNullException>(() => Environment.ExpandEnvironmentVariables(null));
    }

    [Fact]
    public void EmptyArgumentReturnsEmpty()
    {
        Assert.Equal(String.Empty, Environment.ExpandEnvironmentVariables(String.Empty));
    }

    [Fact]
    public void ExpansionOfVariableSucceeds()
    {
        // The test is going to test that we can correctly expand variables.
        // We are going to do:
        // envvar1=animal;
        // and we are going to check that the expanded %envvar1% is animal.

        Random r = new Random();
        string envVar1 = "TestVariable_ExpansionOfVariableSucceeds_" + r.Next().ToString();
        string expectedValue = "animal";

        try
        {
            Environment.SetEnvironmentVariable(envVar1, expectedValue);

            string result = Environment.ExpandEnvironmentVariables("%" + envVar1 + "%");

            Assert.Equal(expectedValue, result);
        }
        finally
        {
            // Clear the variables we just set
            Environment.SetEnvironmentVariable(envVar1, null);
        }
    }

    [Fact]
    public void VariableThatDoesNotExistGoesThroughUnexpanded()
    {
        string unexpanded = "%TestVariable_ThatDoesNotExist%";
        Assert.Equal(unexpanded, Environment.ExpandEnvironmentVariables(unexpanded));
    }

    [Fact]
    public void StringWithNoEnvironmentVariablesGoesThroughUnchnaged()
    {
        Assert.Equal("Hello World", Environment.ExpandEnvironmentVariables("Hello World"));
    }

    [Fact]
    public void PotentiallyAmbiguousInputIsHandledCorrectly()
    {
        int count = 6;
        string prefix = "ExpandTestVar_@";
        string[] keys = new string[count];
        string[] values = new string[count];

        for (int i = 0; i < count; i++)
        {
            keys[i] = prefix + (i + 1);
            Assert.Equal(null, Environment.GetEnvironmentVariable(keys[i]));

            if (i < 3)
            {
                Environment.SetEnvironmentVariable(keys[i], "value" + (i + 1));
            }
        }

        string set1 = keys[0], set2 = keys[1], set3 = keys[2];
        string unset1 = keys[3], unset2 = keys[4], unset3 = keys[5];
        string value1, value2, value3;

        value1 = "value1";
        value2 = "value2";
        value3 = "value3";

        Test("%",
              "%");

        Test("%%",
              "%%");

        Test("%%%",
              "%%%");

        Test(("%" + set1 + "%") + set2 + ("%" + set3 + "%"),
               value1 + set2 + value3);

        Test("%" + ("%" + set1 + "%"),
              "%" + value1);

        Test("%%" + ("%" + set1 + "%") + "%%",
              "%%" + value1 + "%%");

        Test("%%%" + ("%" + set1 + "%") + "%",
              "%%%" + value1 + "%");

        Test(("%" + set1 + "%") + ("%" + set2 + "%"),
              value1 + value2);

        Test(("%" + unset1 + "%") + ("%" + set1 + "%"),
              ("%" + unset1 + "%") + value1);

        Test(("%" + set2 + "%") + "hello" + ("%" + unset2 + "%"),
              value2 + "hello" + ("%" + unset2 + "%"));

        Test(("%" + unset2 + "%") + ("%" + unset3 + "%"),
              ("%" + unset2 + "%") + ("%" + unset3 + "%"));

        Test("% " + set1 + "%",
              "% " + set1 + "%");

        Test("%  " + set1 + "  %",
              "%  " + set1 + "  %");

        Test("%\t" + set1 + "%",
              "%\t" + set1 + "%");

        Test("%%% " + set1 + "%",
              "%%% " + set1 + "%");
    }

    private void Test(string toExpand, string expectedExpansion)
    {
        Assert.Equal(expectedExpansion, Environment.ExpandEnvironmentVariables(toExpand));
        Assert.Equal("qq" + expectedExpansion + "rr", "qq" + Environment.ExpandEnvironmentVariables(toExpand) + "rr");
    }
}
