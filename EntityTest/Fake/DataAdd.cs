using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTest.Models;
using EntityTest.DataAccess;

namespace EntityTest.Fake
{
	public class DataAdd
	{
		public static void FillDb(out int productsCount, out int manufacturersCount, out int measuresCount, out int priceListCount, out int checkCount)
		{
			var random = new Random();
			var productsRandomCount = random.Next(50, 150);
			var products = new List<Product>();
			var priceLists = new List<PriceList>();
			var measures = new List<Measure>
			{
				new Measure { Name = "кг" },
				new Measure { Name = "л" },
				new Measure { Name = "шт" }
			};
			var manufacturers = new List<Manufacturer>
			{
				new Manufacturer { Name = "ООО Продукт продакшн" },
				new Manufacturer { Name = "ОАО Прибалтика" },
				new Manufacturer { Name = "ФЛП Михалыч" }
			};

			manufacturers.ForEach(manufacturer =>
			{
				manufacturer.Phone = (380).CompareRandom(5);
				manufacturer.WebSite = $"{"www.".CompareRandom(10)}.com.ua";
			});

			for (int i = 0; i < 100; i++)
			{
				products.Add(new Product
				{
					Name = "Product_".CompareRandom(8),
					Barcode = i.CompareRandom(100000),
					MeasureId = random.Next(1, 3),
					ManufacturerId = random.Next(1, 3),
					CreatedAt = DateTime.Now,
					UpdatedAt = DateTime.Now,
					Description = "Simple test description: ".CompareRandom(50)
				});
			}

			using (var context = new Context())
			{
				measures.ForEach(measure => context.Measures.Add(measure));
				manufacturers.ForEach(manufacturer => context.Manufacturers.Add(manufacturer));
				products.ForEach(product => context.Products.Add(product));

				context.SaveChanges();

				measuresCount = context.Measures.Count();
				manufacturersCount = context.Manufacturers.Count();
				productsCount = context.Products.Count();
			}
		}
	}
}
