using NorthwestLab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthwestLab.DAL
{
    public class NorthwestDbContext: DbContext
    {
        public NorthwestDbContext() :base("DefaultConnection")
        {

        }

    }

}