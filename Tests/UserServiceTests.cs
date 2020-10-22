using System;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Kernel;
using AutoFixture.Repositories;
using AutoFixture.Services;
using AutoFixture.Xunit2;
using Moq;
using Tests.Extensions;
using Xunit;

namespace Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void Sut_Creation_ThrowsError()
        {
            var fixture = new Fixture();
            
            // var sut = fixture.Create<UserService>();
        }

        [Fact]
        public void Sut_WasCreated_With_TypeRelay()
        {
            var fixture = new Fixture();

            fixture.Customizations.Add(
                new TypeRelay(
                    typeof(IUserRepository),
                    typeof(UserRepository)));

            fixture.Create<UserService>();
        }

        [Fact]
        public void Sut_WasCreated_With_AutoMoqCustomization()
        {
            var fixture = new Fixture().Customize(new AutoMoqCustomization());

            var sut = fixture.Create<UserService>();
        }

        [Fact]
        public void Freeze_CustomType()
        {
            // Arrange
            var fixture = new Fixture().Customize(new AutoMoqCustomization());

            var userName = "TestUsername";

            var mockUserRepo = fixture.Freeze<Mock<IUserRepository>>();
            mockUserRepo.Setup(userRepo => userRepo.GetUserName()).Returns(userName);

            var sut = fixture.Create<UserService>();

            // Act
            var result = sut.GetUserName();

            // Assert
            Assert.Equal(userName, result);
        }

        [Fact]
        public void Verify_Without_Setup()
        {
            // Arrange
            var fixture = new Fixture().Customize(new AutoMoqCustomization());
            var mockUserRepo = fixture.Freeze<Mock<IUserRepository>>();
            var sut = fixture.Create<UserService>();

            // Act
            sut.GetUserName();

            // Assert
            mockUserRepo.Verify(m=>m.GetUserName(), Times.Once);
        }

        [Theory]
        [AutoMoqData]
        public void Use_AutoDataAttribute(
            [Frozen]Mock<IUserRepository> mockUserRepo,
            UserService sut)
        {
            sut.GetUserName();

            mockUserRepo.Verify(m => m.GetUserName(), Times.Once);
        }
    }
}
