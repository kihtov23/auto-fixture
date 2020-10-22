using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFixture.Repositories
{
    public class UserRepository : IUserRepository
    {
        public string GetUserName()
        {
            return "ABC";
        }
    }
}
