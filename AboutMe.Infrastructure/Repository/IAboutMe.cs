using AboutMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AboutMe.Infrastructure.Repository
{
    public interface IAboutMe
    {
        MyInfo getMyDetails();
    }
}