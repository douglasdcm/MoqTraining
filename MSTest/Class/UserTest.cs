using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Moq;
using MoqTraining;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestMock.Class
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void CheckSaveUserToDatabaseIsCalled()
        {
            User user = new User()
            {
                Id = 1,
                Name = "Name",
                Age = 34
            };

            Mock<IServiceDAO> mock = new Mock<IServiceDAO>();
            mock.Setup(x => x.SaveToDatabase(user));

            user.setDao(mock.Object);

            user.save(user);
            
        }

        public void CheckTheIdIsUnique()
        {

        }
    }
}
