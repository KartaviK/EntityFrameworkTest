using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTest.Models;

namespace EntityTest
{
	/// <summary>
	/// Универсальный класс для хранения пользовательских расширений типов
	/// </summary>
	public static class Extensions
	{
		#region Расширения класса Check

		/// <summary>
		/// Проверяет статус чека на подтвержденность
		/// </summary>
		/// <param name="check">Экземпляр чека</param>
		/// <returns>true, если чек подтвержден</returns>
		public static bool StatusAccepted(this Check check)
		{
			return check.Status == (int)Status.Accepted;
		}

		/// <summary>
		/// Проверяет статус чека на отмененность
		/// </summary>
		/// <param name="check">Экземпляр чека</param>
		/// <returns>true, Если чек был отменен</returns>
		public static bool StatusDenied(this Check check)
		{
			return check.Status == (int)Status.Denied;
		}

		#endregion

		#region Расширения класса String

		/// <summary>
		/// 
		/// </summary>
		/// <param name="str">Класс, имеющий данное расширение</param>
		/// <param name="length">Длина случайной строки</param>
		/// <returns>Случайная строка</returns>
		public static string CompareRandom(this String str, int length)
		{
			Random random = new Random();
			const string chars = "abcdefghijklmnoprstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

			var toCompare = new string(Enumerable.Repeat(chars, length)
				.Select(s => s[random.Next(s.Length)]).ToArray());

			return $"{str}{toCompare}";
		}

		#endregion

		#region Расширения класса Int32

		/// <summary>
		/// Производит новое рандомное число и добавляет к переданному
		/// </summary>
		/// <param name="num">Переданное число, к которому будет идти присоединение</param>
		/// <param name="max">Максимальное число для рандома</param>
		/// <returns>Новое рандомное число</returns>
		public static int CompareRandom(this Int32 num, int max)
		{
			int toCompare = new Random().Next(max);

			return Convert.ToInt32($"{num}{toCompare}");
		}

		#endregion
	}
}
