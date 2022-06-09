using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Helper.Common
{
    public class AssertHelper
    {
        public static void AreEqual(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException(
                            $"Expect must be: {expected}, {actual} :(");
            }
        }

        public static void IsFalse(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException(
                            $"Expect must be: {expected}, {actual} :(");
            }
        }

        public static void ShouldContain(string expected, string actual)
        {
            try
            {
                if (actual.Contains(expected))
                    return;
                else if (expected.Contains(actual))
                    return;
                else
                    throw new AssertFailedException(
                            $"Expect must be contain beatween: {expected} and {actual} :(");
            }
            catch (Exception)
            {
                throw new AssertFailedException(
                            $"Expect must be: {expected}, {actual} :(");
            }
        }
    }
}
