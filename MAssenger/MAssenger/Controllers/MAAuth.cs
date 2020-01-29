﻿using MAssenger.DAL;
using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public interface IAuthentication
    {
        Session Login(User user);
        bool Logout(Session session);
        bool Logout(UInt64 id);
        bool IsValid(User user);
        bool IsValid(Session session);
    }

    public class MAAuth : IAuthentication
    {
        public Session Login(User user)
        {
            Session session = new Session(1, user, DateTime.MaxValue, LoginType.MAssenger, "A0-51-0B-BB-B8-3C");
            SessionRepo sessionRepo = new SessionRepo();
            sessionRepo.Create(session);
            return session; 
        }
        public bool Logout(Session session)
        {
            SessionRepo sessionRepo = new SessionRepo();
            return sessionRepo.Delete(session);
        }
        public bool Logout(UInt64 id)
        {
            SessionRepo sessionRepo = new SessionRepo();
            return sessionRepo.Delete(id);
        }
        public bool IsValid(User user)
        {
            return true;
        }
        public bool IsValid(Session session)
        {
            return true;
        }
    }
}