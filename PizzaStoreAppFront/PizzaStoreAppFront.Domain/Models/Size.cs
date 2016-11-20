using PizzaStoreAppFront.Domain.SizeServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class Size {
        public int SizeId { get; set; }
        public int Dimension { get; set; }
        public decimal Price { get; set; }

        public static Size FromDAO(SizeDAO sizeDAO) {
            return new Size {
                SizeId = sizeDAO.SizeId,
                Dimension = sizeDAO.Dimension,
                Price = sizeDAO.Price
            };
        }
    }
}
