using GAMIN.BO;
using GAMIN.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMIN.BLL
{
    public class UserBLO
    {
        UserDAO userRepo;

        public UserBLO(string dbFolder)
        {
            userRepo = new UserDAO(dbFolder);
        }
        public void CreateUser(User user)
        {
            userRepo.Add(user);
        }

        public void DeleteUser(User user)
        {
            userRepo.Remove(user);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return userRepo.Find();
        }
        public User GetUser()
        {
            User company = userRepo.Get();

            return company;
        }
        public IEnumerable<User> GetByReference(string matricule)
        {
            return userRepo.Find(x => x.Matricule == matricule);
        }
        public IEnumerable<User> GetBy(Func<User, bool> predicate)
        {
            return userRepo.Find(predicate);
        }

        public void EditUser(User oldUser, User newUser)
        {
            userRepo.Set(oldUser, newUser);
        }

      
    }
}
