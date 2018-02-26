using PlataformaRPHD.Domain.Entities.Entities;
using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlataformaRPHD.Web.Services
{
    public class UserService
    {
        private readonly IUnitOfWork unitOfWork;

        public UserService()
        {
            this.unitOfWork = new UnitOfWork(new STICketContext());
        }

        public User UpdateUserInDB(string samAccountName)
        {
            ActiveDirectoryReadOnlyRepository ad = new ActiveDirectoryReadOnlyRepository();
            ActiveDirectoryUser userAD = ad.GetUser(samAccountName);
            User userDB = unitOfWork.UserRepository.GetUserBySamAccountName(samAccountName);
            if(userDB == null)
            {
                UserName un = new UserName(userAD.Name, userAD.Surname);
                userDB = new User(un, userAD.SamAccountName, userAD.EmailAddress, "");
                unitOfWork.UserRepository.Insert(userDB);
                unitOfWork.SaveChanges();
            }
            else
            {
                userDB.mail = userAD.EmailAddress;
                unitOfWork.UserRepository.InsertOrUpdate(userDB);
                unitOfWork.SaveChanges();
            }
            return userDB;
        }
    }
}