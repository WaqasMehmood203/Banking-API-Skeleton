using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models.Entities;

namespace Task.Data
{
    public class ApplicationDbContext  
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientQueryParameter> ClientQueryParameters { get; set; }


        public ApplicationDbContext(DbContextOptions options)
        {
        }
    }
     


}
