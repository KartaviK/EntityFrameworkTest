using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityTest.Models
{
	/// <summary>
	/// Представление данных о производителе/поставщике
	/// </summary>
    public class Manufacturer
    {
		/// <summary>
		/// Уникальный идентификатор
		/// </summary>
        public int Id { get; set; }

		/// <summary>
		/// Наименование
		/// </summary>
        public string Name { get; set; }

		/// <summary>
		/// Адрес местонахождения
		/// </summary>
        public string Address { get; set; }

		/// <summary>
		/// Номер телефона для связи
		/// </summary>
        public int Phone { get; set; }

		/// <summary>
		/// Ссылка на личный сайт
		/// </summary>
        public string WebSite { get; set; }

		/// <summary>
		/// Коллекция продуктов
		/// </summary>
		/// <remarks>
		/// Свойство навигации для приложения
		/// </remarks>
		public virtual ICollection<Product> Product { get; set; }
    }
}
