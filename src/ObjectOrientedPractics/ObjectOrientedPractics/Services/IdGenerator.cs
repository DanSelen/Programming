using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс <see cref="IdGenerator"/> предоставляет функциональность для генерации уникальных идентификаторов.
    /// </summary>
    internal class IdGenerator
    {
        /// <summary>
        /// Счетчик для хранения последнего сгенерированного идентификатора.
        /// Статическое поле, общее для всех экземпляров класса.
        /// </summary>
        private static int _counter;

        /// <summary>
        /// Генерирует следующий уникальный идентификатор.
        /// </summary>
        /// <returns>Возвращает следующий уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            return _counter++;
        } 
    }
}
