using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityTest.Models;

namespace EntityTest.DataAccess
{
	public class Context : DbContext
	{
		public DbSet<Product> Products { get; set; }

		public DbSet<Manufacturer> Manufacturers { get; set; }

		public DbSet<Measure> Measures { get; set; }

		public DbSet<Check> Checks { get; set; }

		public DbSet<PriceList> PriceLists { get; set; }
	}
}
