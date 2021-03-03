using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerCommLib;
using Moq;

namespace CustomerCommTests
{
    [TestFixture]
    public class Class1
    {
        IMailSender mailSender;
        Mock<IMailSender> mock;
        CustomerComm cc;
        [Test]
        [TestCase("cust123@abc.com", "Some Message", true)]
        [TestCase("OneIT@cognizant.com", "Hi Team", true)]
        public void SendMail_with_CustomerComm(string toAddress , string message,bool expected) {

            mock = new Mock<IMailSender>(MockBehavior.Loose);
            cc = new CustomerComm(mock.Object);
            mock.Setup(p => p.SendMail(toAddress, message)).Returns(expected);
            bool actual = cc.SendMailToCustomer();
            Assert.AreEqual(expected, actual);
        
        }
    }
}
