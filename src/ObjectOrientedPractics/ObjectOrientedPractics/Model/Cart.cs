using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс <see cref="Cart"/> представляет корзину покупателя.
    /// </summary>
    public class Cart
    {
        private List<Item> _items;

        /// <summary>
        /// Получает или задает список товаров.
        /// </summary>
        /// 
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Получает цену товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items == null || Items.Count == 0)
                {
                    return 0.0;
                }

                double totalPrice = 0.0;
                foreach (var item in Items)
                {
                    totalPrice += item.Cost; 
                }

                return totalPrice;
            }
        }
    }
}
