﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

[TestFixture]
public class SimpleAddSubtractToolTests
{
    [Test]
    public void SumOfTwoNumbers()
    {
        SimpleAddSubtractTool sas = new SimpleAddSubtractTool();
        Assert.AreEqual(10, sas.Add(5, 5));
    }
}
