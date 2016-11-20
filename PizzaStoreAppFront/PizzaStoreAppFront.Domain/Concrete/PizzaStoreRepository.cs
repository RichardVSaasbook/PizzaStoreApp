using PizzaStoreAppFront.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreAppFront.Domain.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;

namespace PizzaStoreAppFront.Domain.Concrete {
    public class PizzaStoreRepository : IPizzaStoreRepository {
        private HttpClient client;
        private const string BASE_URL = "http://localhost/pizzastore/api/";

        public PizzaStoreRepository() {
            client = new HttpClient();
        }

        public Ingredient GetIngredient(int ingredientId) {
            return GetObject<Ingredient>("ingredient/" + ingredientId);
        }

        public Size GetSize(int sizeId) {
            return GetObject<Size>("size/" + sizeId);
        }

        public IEnumerable<Ingredient> ListIngredients(string type) {
            return GetObject<List<Ingredient>>("ingredients/" + type);
        }

        public IEnumerable<Size> ListSizes() {
            return GetObject<List<Size>>("size");
        }

        private T GetObject<T>(string url) where T : class, new() {
            HttpResponseMessage response = client.GetAsync(BASE_URL + url).Result;

            if (response.IsSuccessStatusCode) {
                var stream = response.Content.ReadAsStreamAsync().Result;
                var serializer = new DataContractJsonSerializer(typeof(T));
                return serializer.ReadObject(stream) as T;
            }

            return new T();
        }
    }
}
