using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppBack.DataAccess {
    public partial class PizzaStoreAppData {
        /// <summary>
        /// List all of the Pizza Sizes.
        /// </summary>
        /// <returns>The List of Sizes.</returns>
        public List<Size> ListSizes() {
            return db.Sizes.Where(s => s.Active).ToList();
        }
    }
}
