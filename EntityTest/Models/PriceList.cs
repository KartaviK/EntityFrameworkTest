using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
	/// <summary>
	/// Представление товара в наличии по закупке
	/// </summary>
	public class PriceList
	{
		/// <summary>
		/// Уникальный идентификатор
		/// </summary>
		public int Id { get; set; }
		
		/// <summary>
		/// Идентификатор купленого продукта
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// Количество продукта
		/// </summary>
		public Int16 Quantity { get; set; }

		/// <summary>
		/// Цена закупки товара
		/// </summary>
		public int PurchasePrice { get; set; }

		/// <summary>
		/// Цена продажи товара для конечного покупателя
		/// </summary>
		public int SellingPrice { get; set; }

		/// <summary>
		/// Дата создания в таблице (дата закупки товара в магазин)
		/// </summary>
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// Коллекция продуктов
		/// </summary>
		///	<remarks>
		/// Свойство для навигации в приложении
		/// </remarks>
		public virtual ICollection<Product> Product { get; set; }
	}
}
