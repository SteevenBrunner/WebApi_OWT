﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi_OWT.Data
{
    public class WebApi_OWTContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApi_OWTContext() : base("name=WebApi_OWTContext")
        {
        }

        public DbSet<Models.Contact> Contacts { get; set; }

        public DbSet<Models.Skills> Skills { get; set; }
    }
}
