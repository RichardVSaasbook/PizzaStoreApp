using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppBack.DataAccess
{
    /// <summary>
    /// Accesses and modifies data from the PizzaStoreApp database.
    /// </summary>
    public partial class PizzaStoreAppData
    {
        private PizzaStoreAppEntities db;

        /// <summary>
        /// Create a new PizzaStoreApp data access.
        /// </summary>
        public PizzaStoreAppData()
        {
            db = new PizzaStoreAppEntities();
        }

        /// <summary>
        /// Find an Address entity.
        /// </summary>
        /// <param name="addressId">The Id of the Address to find.</param>
        /// <returns>The Address if found or a new one otherwise.</returns>
        public Address FindAddress(int addressId)
        {
            return FindEntity(db.Addresses, addressId);
        }

        /// <summary>
        /// Find an Ingredient entity.
        /// </summary>
        /// <param name="ingredientId">The Id of the Ingredient to find.</param>
        /// <returns>The Ingredient if found or a new one otherwise.</returns>
        public Ingredient FindIngredient(int ingredientId)
        {
            return FindEntity(db.Ingredients, ingredientId);
        }

        /// <summary>
        /// Find an Order entity.
        /// </summary>
        /// <param name="orderId">The Id of the Order to find.</param>
        /// <returns>The Order if found or a new one otherwise.</returns>
        public Order FindOrder(int orderId)
        {
            return FindEntity(db.Orders, orderId);
        }

        /// <summary>
        /// Find a Person entity.
        /// </summary>
        /// <param name="personId">The Id of the Person to find.</param>
        /// <returns>The Person if found or a new one otherwise.</returns>
        public Person FindPerson(int personId)
        {
            return FindEntity(db.People, personId);
        }

        /// <summary>
        /// Find a Phone entity.
        /// </summary>
        /// <param name="phoneId">The Id of the Phone to find.</param>
        /// <returns>The Phone if found or a new one otherwise.</returns>
        public Phone FindPhone(int phoneId)
        {
            return FindEntity(db.Phones, phoneId);
        }

        /// <summary>
        /// Find a Pizza entity.
        /// </summary>
        /// <param name="pizzaId">The Id of the Pizza to find.</param>
        /// <returns>The Pizza if found or a new one otherwise.</returns>
        public Pizza FindPizza(int pizzaId)
        {
            return FindEntity(db.Pizzas, pizzaId);
        }
        
        /// <summary>
        /// Find a PizzaIngredient entity.
        /// </summary>
        /// <param name="pizzaId">The Id of the Pizza to find.</param>
        /// <param name="ingredientId">The Id of the Ingredient to find.</param>
        /// <returns>The PizzaIngredient if found or a new one otherwise.</returns>
        public PizzaIngredient FindPizzaIngredient(int pizzaId, int ingredientId)
        {
            return FindEntity(db.PizzaIngredients, pizzaId, ingredientId);
        }

        /// <summary>
        /// Find a PizzaOrder entity.
        /// </summary>
        /// <param name="pizzaId">The Id of the Pizza to find.</param>
        /// <param name="orderId">The Id of the Order to find.</param>
        /// <returns>The PizzaOrder if found or a new one otherwise.</returns>
        //public PizzaOrder FindPizzaOrder(int pizzaId, int orderId)
        //{
        //    return FindEntity(db.PizzaOrders, pizzaId, orderId);
        //}

        /// <summary>
        /// Find a Size entity.
        /// </summary>
        /// <param name="sizeId">The Id of the Size to find.</param>
        /// <returns>The Size if found or a new one otherwise.</returns>
        public Size FindSize(int sizeId)
        {
            return FindEntity(db.Sizes, sizeId);
        }

        /// <summary>
        /// Find a SpecialtyPizza entity.
        /// </summary>
        /// <param name="specialtyPizzaId">The Id of the SpecialtyPizza to find.</param>
        /// <returns>The SpecialtyPizza if found or a new one otherwise.</returns>
        public SpecialtyPizza FindSpecialtyPizza(int specialtyPizzaId)
        {
            return FindEntity(db.SpecialtyPizzas, specialtyPizzaId);
        }

        /// <summary>
        /// Find a SpecialtyPizzaIngredient entity.
        /// </summary>
        /// <param name="specialtyPizzaId">The Id of the SpecialtyPizza to find.</param>
        /// <param name="ingredientId">The Id of the Ingredient to find.</param>
        /// <returns>The SpecialtyPizzaIngredient if found or a new one otherwise.</returns>
        public SpecialtyPizzaIngredient FindSpecialtyPizzaIngredient(int specialtyPizzaId, int ingredientId)
        {
            return FindEntity(db.SpecialtyPizzaIngredients, specialtyPizzaId, ingredientId);
        }

        /// <summary>
        /// Find a Store entity.
        /// </summary>
        /// <param name="storeId">The Id of the Store to find.</param>
        /// <returns>The Store if found or a new one otherwise.</returns>
        public Store FindStore(int storeId)
        {
            return FindEntity(db.Stores, storeId);
        }

        /// <summary>
        /// Find a StoreIngredient entity.
        /// </summary>
        /// <param name="storeId">The Id of the Store to find.</param>
        /// <param name="ingredientId">The Id of the Ingredient to find.</param>
        /// <returns>The StoreIngredient if found or a new one otherwise.</returns>
        public StoreIngredient FindStoreIngredient(int storeId, int ingredientId)
        {
            return FindEntity(db.StoreIngredients, storeId, ingredientId);
        }

        /// <summary>
        /// Find an entity in the database.
        /// </summary>
        /// <typeparam name="T">The type of entity to find.</typeparam>
        /// <param name="entities">The DbSet containing the type of entities.</param>
        /// <param name="entityIds">The Id(s) for the entity.</param>
        /// <returns>The found entity, or a blank one if it was not found.</returns>
        private T FindEntity<T>(DbSet<T> entities, params int[] entityIds) where T : class, new()
        {
            T entity = entities.Find(entityIds);

            if (entity == null)
            {
                entity = new T();
            }

            return entity;
        }
    }
}
