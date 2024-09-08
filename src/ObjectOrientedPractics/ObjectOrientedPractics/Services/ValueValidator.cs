using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс ValueValidator предоставляет методы для валидации строковых и числовых значений.
    /// </summary>
    internal class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки и выбрасывает исключение, если строка длиннее заданного максимума или короче нуля.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        /// <param name="propertyName">Имя свойства, к которому применяется проверка.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если длина строки меньше нуля или превышает максимально допустимую длину.
        /// </exception>
        public static void AssertStringOnLength(string value, int maxLength,string propertyName)
        {
            if (value.Length < 0 ||value.Length>maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов"); // меньше maxLength символов и больше нуля
            }
        }

        /// <summary>
        /// Проверяет, находится ли вещественное значение в заданном диапазоне, и выбрасывает исключение, если не находится.
        /// </summary>
        /// <param name="value">Проверяемое вещественное число.</param>
        /// <param name="minValue">Минимально допустимое значение.</param>
        /// <param name="maxValue">Максимально допустимое значение.</param>
        /// <param name="propertyName">Имя свойства, к которому применяется проверка.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если значение выходит за границы допустимого диапазона.
        /// </exception>
        public static void AssertDoubleOnValue(double value,double minValue ,double maxValue, string propertyName)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException($"{propertyName} должен быть в диапазоне между {minValue} и {maxValue}");
            }
        }
    }
}
