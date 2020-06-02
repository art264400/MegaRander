using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Rent.Context;
using Rent.Interfaces;
using Rent.Models;
using Rent.Models.Tag;
using NotImplementedException = System.NotImplementedException;

namespace Rent.Services
{
    public class EntityRentService : IRentService
    {
        public User[] GetAllUsers()
        {
            using (var db = new RentContext())
            {
                return db.Users.Where(m => m.IsDeleted == false).ToArray();
            }
        }

        public User GetUserById(int id)
        {
            using (var db = new RentContext())
            {
                return db.Users.FirstOrDefault(m => m.Id == id);
            }
        }

        public User GetUserByLogin(string login)
        {
            using (var db = new RentContext())
            {
                return db.Users.FirstOrDefault(m => m.Login == login);
            }
        }

        public bool RemoveUserById(int id)
        {
            using (var db = new RentContext())
            {
                var user = GetUserById(id);
                if (user == null) return false;
                user.IsDeleted = true;
                db.Users.AddOrUpdate(user);
                db.SaveChanges();
                return true;
            }
        }

        public bool updateUser(User updateUser)
        {
            using (var db = new RentContext())
            {
                db.Users.AddOrUpdate(updateUser);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateUserById(int id)
        {
            throw new NotImplementedException();
        }

        public bool VerifyUserByLoginAndPassword(LoginTag loginModel)
        {
            using (var db = new RentContext())
            {
                var user = db.Users.FirstOrDefault(m => m.Login == loginModel.Login && m.Password == loginModel.Password);
                if (user != null)
                {
                    return true;
                }

                return false;
            }
        }

        public Product[] GetAllProducts()
        {
            using (var db = new RentContext())
            {
                return db.Products
                    .Where(m => m.IsDeleted == false && m.IsReserved == false && m.IsTaken == false)
                    .Include(m => m.Category)
                    .Include(m => m.User)
                    .ToArray();
            }
        }

        public Product GetProductById(int id)
        {
            using (var db = new RentContext())
            {
                var product = db.Products.Include(m => m.Category).Include(m => m.User).FirstOrDefault(m =>
                        m.IsDeleted == false && m.IsReserved == false && m.IsTaken == false && m.Id == id);
                return product;
            }
        }
        //списываем деньги у пользователя по логину
        public bool WriteOffMoneyFromUserByLogin(decimal money, string login)
        {
            using (var db = new RentContext())
            {
                var user = db.Users.FirstOrDefault(m => m.Login == login);
                if (user == null) return false;
                if (user.SumMoney < money) return false;
                user.SumMoney -= money;
                db.Users.AddOrUpdate(user);
                db.SaveChanges();
                return true;
            }
        }

        public bool CheckedReservedProductByProductId(int id)
        {
            using (var db = new RentContext())
            {
                var product = db.Products.Include(m => m.User).FirstOrDefault(m => m.Id == id);
                if (product == null) return false;
                product.IsReserved = true;
                db.Products.AddOrUpdate(product);
                db.SaveChanges();
                return true;
            }
        }

        public Product[] GetProductByUserId(int id)
        {
            using (var db = new RentContext())
            {
                return db.Products.Include(m => m.User).Include(m => m.Category).Where(m => m.UserId == id).ToArray();
            }
        }
    }
}