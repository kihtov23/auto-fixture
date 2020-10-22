using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture.Repositories;
using AutoFixtureDemo.Services;

namespace AutoFixture.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IServiceWithPrimitiveTypes _serviceWithPrimitiveTypes;

        public UserService(IUserRepository userRepository, IServiceWithPrimitiveTypes serviceWithPrimitiveTypes)
        {
            _userRepository = userRepository;
            _serviceWithPrimitiveTypes = serviceWithPrimitiveTypes;
        }

        public string GetUserName()
        {
            return _userRepository.GetUserName();
        }

        public string GetPrimitiveName()
        {
            return _serviceWithPrimitiveTypes.Name;
        }
    }
}
