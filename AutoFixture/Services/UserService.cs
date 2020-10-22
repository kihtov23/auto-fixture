using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture.Repositories;

namespace AutoFixture.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string GetUserName()
        {
            return _userRepository.GetUserName();
        }
    }
}
