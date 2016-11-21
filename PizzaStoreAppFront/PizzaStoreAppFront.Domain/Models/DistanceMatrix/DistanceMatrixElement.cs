using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models.DistanceMatrix {
    public class DistanceMatrixElement {
        public string status { get; set; }
        public DistanceMatrixKeyValue duration { get; set; }
        public DistanceMatrixKeyValue distance { get; set; }
    }
}
