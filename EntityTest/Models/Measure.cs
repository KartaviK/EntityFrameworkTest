using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
	/// <summary>
	/// Представление одной единицы измерения из базы
	/// </summary>
	public class Measure
	{
		/// <summary>
		/// Уникальный идентификатор
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Наименование измерения
		/// </summary>
		public string Name { get; set; }
	}
}
