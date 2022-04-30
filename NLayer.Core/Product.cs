using System;
namespace NLayer.Core
{
	//Metod içerisindeki field ve metodların default erişim belirteci private
	//Class'ların ise internal'dır
	public class Product : BaseEntity
	{
        public string Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
    }
}

