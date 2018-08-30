using JakeRenzo.Shutdown.Web.Infrastructure.Data.Helpers;
using JakeRenzo.Shutdown.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakeRenzo.Shutdown.Web.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
