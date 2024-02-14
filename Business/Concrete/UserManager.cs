using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository userRepository;
        public UserManager(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
        public User CreateUser(User user)
        {
            return userRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            userRepository.DeleteUser(id);
        }

        public List<User> GetAllUser()
        {
            return userRepository.GetAllUser();
        }

        public User GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }

        public User UpdateUser(User user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
