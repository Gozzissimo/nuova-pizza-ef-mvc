﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nuova_pizza_ef_mvc.Models
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizze { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=pizzeria;Integrated Security=True;Pooling=False");
        }
    }
}
