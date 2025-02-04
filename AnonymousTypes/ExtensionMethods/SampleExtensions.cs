using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{

    /// <summary>
    /// Bu sınıf, çeşitli uzantı yöntemlerini içerir.
    /// </summary>
    public static class SampleExtensions
    {
        /// <summary>
        /// Verilen değerin karesini döndürür.
        /// </summary>
        /// <param name="value">Kare alınacak değer.</param>
        /// <returns>Verilen değerin karesi.</returns>
        public static int GetSquare(this int value)
        {
            return value * value;
        }

        /// <summary>
        /// Verilen değerin belirtilen kuvvetini döndürür.
        /// </summary>
        /// <param name="value">Kuvvet alınacak değer.</param>
        /// <param name="power">Uygulanacak kuvvet.</param>
        /// <returns>Verilen değerin belirtilen kuvveti.</returns>
        public static double GetPower(this int value, int power)
        {
            return Math.Pow(value, power);
        }

        /// <summary>
        /// Belirtilen tarihteki yıl içinde toplam çalışma günlerini döndürür.
        /// </summary>
        /// <param name="dateTime">Tarih bilgisi.</param>
        /// <param name="holidays">Tatil günleri.</param>
        /// <returns>Toplam çalışma günleri.</returns>
        public static int TotalWorkDays(this DateTime dateTime, DateTime[] holidays)
        {
            DateTime start = new DateTime(dateTime.Year, 1, 1);
            DateTime end = new DateTime(dateTime.Year, 12, 31);

            int totalDays = 0;
            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (!holidays.Contains(date))
                    {
                        totalDays++;
                    }
                }
            }

            return totalDays;
        }
    }
}
