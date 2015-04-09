using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebApplication1.Tests
{
    [TestFixture]
    public class Class2
    {
        [Test]
        public void CalYear()
        {
            BO.Cal cal = new BO.Cal();
            int inputAge = 30;
            int expect = 1988;

            Assert.AreEqual(expect, cal.GetBirthYear(inputAge, BO.Cal.YearFormat.W));
        }
    }
}
