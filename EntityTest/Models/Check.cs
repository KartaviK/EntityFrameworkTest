using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
	/// <summary>
	/// Представление чека по купле/продажи товаров
	/// </summary>
	public class Check
	{
		/// <summary>
		/// Уникальный идентификатор
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Общая цена чека
		/// </summary>
		public int Amount { get; set; }

		/// <summary>
		/// Ццена, заплаченная по чеку
		/// </summary>
		public int Paid { get; set; }

		/// <summary>
		/// Сдача от цены, заплаченной по чеку
		/// </summary>
		public int Change { get; set; }

		/// <summary>
		/// Чек может быть отменен, в этом случае требуется изменить статус
		/// </summary>
		public int Status { get; set; }

		/// <summary>
		/// Дата создания в базе
		/// </summary>
		public DateTime CreateaAt { get; set; }

		/// <summary>
		/// Дата последнего обновления в базе
		/// </summary>
		public DateTime UpdatedAt { get; set; }

		/// <summary>
		/// Сериализованные данные о количестве продуктов в чеке
		/// </summary>
		/// <example>
		/// productId=250;
		/// </example>
		public string Products { get; private set; }

		/// <summary>
		/// Коллекция, хранящее идентификатор=количество продукта 
		/// </summary>
		public Dictionary<int, int> ProductsDictionary
		{
			get
			{
				return this.Products.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(part => part.Split('='))
					.ToDictionary(split => Convert.ToInt32(split[0]), split => Convert.ToInt32(split[1]));
			}

			set
			{
				var products = value;
				this.Products = "";

				foreach (var product in products)
				{
					this.Products += $"{product.Key}={product.Value};";
				}
			}
		}

		/// <summary>
		/// Сериализованные данные о цене продукта в чеке
		/// </summary>
		/// <example>
		/// productId=12;
		/// </example>
		public string Prices { get; private set; }

		/// <summary>
		/// Коллекция, хранящее идентификатор=цена продукта 
		/// </summary>
		public Dictionary<int, int> PricesDictinary
		{
			get
			{
				return this.Prices.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(part => part.Split('='))
					.ToDictionary(split => Convert.ToInt32(split[0]), split => Convert.ToInt32(split[1]));
			}

			set
			{
				var prices = value;
				this.Prices = "";

				foreach (var prise in prices)
				{
					this.Prices += $"{prise.Key}={prise.Value};";
				}
			}
		}
	}
}
