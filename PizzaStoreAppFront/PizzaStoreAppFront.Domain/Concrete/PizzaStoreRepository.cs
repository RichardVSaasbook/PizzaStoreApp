using PizzaStoreAppFront.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreAppFront.Domain.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using PizzaStoreAppFront.Domain.Models.DistanceMatrix;
using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
using System.Web.Configuration;

namespace PizzaStoreAppFront.Domain.Concrete {
    public class PizzaStoreRepository : IPizzaStoreRepository {
        private HttpClient client;
        private const string BASE_URL = "http://localhost/pizzastore/api/";

        public PizzaStoreRepository() {
            client = new HttpClient();
        }

        public Ingredient GetIngredient(int ingredientId) {
            return GetObject<Ingredient>(BASE_URL + "ingredient/" + ingredientId);
        }

        public Size GetSize(int sizeId) {
            return GetObject<Size>(BASE_URL + "size/" + sizeId);
        }

        public IEnumerable<Ingredient> ListIngredients(string type) {
            return GetObject<List<Ingredient>>(BASE_URL + "ingredients/" + type);
        }

        public IEnumerable<Size> ListSizes() {
            return GetObject<List<Size>>(BASE_URL + "size");
        }

        private T GetObject<T>(string url) where T : class, new() {
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode) {
                var stream = response.Content.ReadAsStreamAsync().Result;
                var serializer = new DataContractJsonSerializer(typeof(T));
                return serializer.ReadObject(stream) as T;
            }

            return new T();
        }

        public List<Pizza> ListPizzasInOrder(int orderId) {
            return GetObject<List<Pizza>>(BASE_URL + "order/" + orderId + "/pizzas");
        }

        public List<Store> ListStores() {
            return GetObject<List<Store>>(BASE_URL + "store");
        }

        public Store GetNearestStore(Address address) {
            StringBuilder googleMatrixRequest = new StringBuilder("https://maps.googleapis.com/maps/api/distancematrix/json?origins=");
            googleMatrixRequest.Append(FormatAddress(address));
            googleMatrixRequest.Append("&destinations=");

            List<Store> stores = ListStores();
            for (int s = 0; s < stores.Count; s++) {
                if (s > 0) {
                    googleMatrixRequest.Append("|");
                }
                
                googleMatrixRequest.Append(FormatAddress(stores[s].Address));
            }

            googleMatrixRequest.Append("&key=");
            googleMatrixRequest.Append(WebConfigurationManager.AppSettings["GoogleMapsDistanceMatrixApiKey"]);

            DistanceMatrix matrix = GetObject<DistanceMatrix>(googleMatrixRequest.ToString());
            DistanceMatrixRow dmr = matrix.rows[0];
            int minDistance = dmr.elements[0].distance.value;
            Store closestStore = stores[0];

            for (int d = 1; d < dmr.elements.Count; d++) {
                DistanceMatrixElement dme = dmr.elements[d];
                
                if (dme.distance.value < minDistance) {
                    closestStore = stores[d];
                }
            }

            return closestStore;
        }

        public List<Person> ListPeople() {
            return GetObject<List<Person>>(BASE_URL + "people");
        }

        public List<Order> ListStoreOrders(int storeId) {
            return GetObject<List<Order>>(BASE_URL + "store/" + storeId + "/orders");
        }

        private string FormatAddress(Address address) {
            string addressString = string.Format(
                "{0}+{1}+{2}+{3}",
                address.Street,
                address.City,
                address.State,
                address.Zip
            );
            
            addressString = addressString.Replace(" ", "+");

            return addressString;
        }
    }
}
