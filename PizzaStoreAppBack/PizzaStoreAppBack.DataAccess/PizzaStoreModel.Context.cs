﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreAppBack.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PizzaStoreAppEntities : DbContext
    {
        public PizzaStoreAppEntities()
            : base("name=PizzaStoreAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<PizzaIngredient> PizzaIngredients { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<SpecialtyPizza> SpecialtyPizzas { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PizzaOrder> PizzaOrders { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreIngredient> StoreIngredients { get; set; }
        public virtual DbSet<SpecialtyPizzaIngredient> SpecialtyPizzaIngredients { get; set; }
    }
}
