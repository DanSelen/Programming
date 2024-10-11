using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс <see cref="AppColors"/> содержит статические свойства для цветов, используемых в приложении.
    /// </summary>
    internal class AppColors
    {
        /// <summary>
        /// Получает цвет по умолчанию (белый).
        /// </summary>
        public static Color DefaultColor  => Color.White;

        /// <summary>
        /// Получает цвет, используемый для отображения ошибок (светло-розовый).
        /// </summary>
        public static Color ErrorColor => Color.LightPink;
    }
}
