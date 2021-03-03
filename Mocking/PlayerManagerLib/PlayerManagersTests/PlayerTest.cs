using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using PlayerManagerLib;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace PlayerManagersTests
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName()
        {
            Player player = Player.RegisterNewPlayer("");
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName_MockedDataMapper()
        {
            var mock = new Mock<IPlayerMapper>();

            Player player = Player.RegisterNewPlayer("", mock.Object);
        }


        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistsInDatabase()
        {
            var mock = new Mock<IPlayerMapper>();
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(true);

            Player player = Player.RegisterNewPlayer("Test", mock.Object);
        }


        [Test]
        public void Test_CreateNewPlayer_DoesNotAlreadyExistInDatabase()
        {
            var mock = new Mock<IPlayerMapper>();
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);

            Player player = Player.RegisterNewPlayer("Test", mock.Object);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(23, player.Age);
            Assert.AreEqual("India", player.Country);
            Assert.AreEqual(30, player.NoOfMatches);
        }
    }
}
