using AboutMe.Domain.Entities;
using AboutMe.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AboutMe.Infrastructure.DAL
{
    public class GetDetails : IAboutMe
    {
        public MyInfo getMyDetails ()
        {
            MyInfo info = new MyInfo();
            info.Name = "Rishabh Jain";
            info.age = 23;
            info.aboutme = "Software Developer";

            return info;
        }
    }
} 