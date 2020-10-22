using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixtureDemo.Models;
using Xunit;

namespace Tests.TestData
{
    public class UsersTestData
    {
        [Fact]
        public void Create_User()
        {
            var fixture = new Fixture().Customize(new AutoMoqCustomization());
            var user = fixture.Build<User>().Create();
        }

        [Fact]
        public void AddManyTo_User()
        {
            var user = new User();
            var fixture = new Fixture().Customize(new AutoMoqCustomization());
            fixture.AddManyTo(user.PatNames);
        }
    }
}
