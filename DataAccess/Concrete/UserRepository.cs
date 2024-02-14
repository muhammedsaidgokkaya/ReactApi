using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(User user)
        {
            using (var c = new SqlDbContext())
            {
                c.Users.Add(user);
                c.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (var c = new SqlDbContext())
            {
                var deleteUser = GetUserById(id);
                c.Users.Remove(deleteUser);
                c.SaveChanges();
            }
        }

        public List<User> GetAllUser()
        {
            using (var c = new SqlDbContext())
            {
                return c.Users.ToList();
            }
        }

        public User GetUserById(int id)
        {
            using (var c = new SqlDbContext())
            {
                return c.Users.Find(id);
            }
        }

        public User UpdateUser(User user)
        {
            using (var c = new SqlDbContext())
            {
                c.Users.Update(user);
                c.SaveChanges();
                return user;
            }
        }
    }
}
