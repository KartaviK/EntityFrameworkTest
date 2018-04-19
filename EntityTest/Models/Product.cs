using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
	/// <summary>
	/// Представление одного продукта из базы
	/// </summary>
    public class Product
    {
		/// <summary>
		/// Уникальный идентификатор
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Личное наименование
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Штрих-код (может отсутствовать)
		/// </summary>
		public int Barcode { get; set; }

		/// <summary>
		/// Уникальный идентификатор производителя
		/// </summary>
		public int ManufacturerId { get; set; }

		/// <summary>
		/// Уникальный идентификатор единицы измерения
		/// </summary>
		public int MeasureId { get; set; }

		/// <summary>
		/// Описание (может отсутствовать)
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Дата создания в базе
		/// </summary>
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// Последнее обновление в базе
		/// </summary>
		public DateTime UpdatedAt { get; set; }

		/// <summary>
		/// Производитель/Поставщик данного продукта
		/// </summary>
		/// <remarks>
		/// Свойство для навигации в приложении
		/// </remarks>
		public virtual Manufacturer Manufacturer { get; set; }

		/// <summary>
		/// Единица измерения продукта
		/// </summary>
		/// <remarks>
		/// Свойство для навигации в приложении
		/// </remarks>
		public virtual Measure Measure { get; set; }
	}
}
