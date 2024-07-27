using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using webPay.Models;

namespace webPay.Models;

public class WebPayDbContext : DbContext
{
 
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Movie> Movies { get; set; }

    public DbSet<MemberShipType> MemberShipType { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=webpay;User=mohamadrahi;password=6222530", ServerVersion.AutoDetect("server=localhost;database=webpay;User=mohamadrahi;password=6222530"));
    }

}

