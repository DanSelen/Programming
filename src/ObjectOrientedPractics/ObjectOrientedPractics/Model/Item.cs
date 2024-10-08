using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Класс <see cref="Item"/> представляет товар с уникальным идентификатором, названием, описанием и стоимостью.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Уникальный идентификатор товара, генерируемый автоматически.
        /// </summary>
        readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Категория товара
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Получает или задает название товара.
        /// Валидация происходит с помощью <see cref="ValueValidator.AssertStringOnLength"/>.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если длина названия превышает 200 символов.
        /// </exception>
        /// 
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Получает или задает описание товара.
        /// Валидация происходит с помощью <see cref="ValueValidator.AssertStringOnLength"/>.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если длина описания превышает 1000 символов.
        /// </exception>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Получает или задает стоимость товара.
        /// Валидация происходит с помощью <see cref="ValueValidator.AssertDoubleOnValue"/>.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если стоимость не входит в диапазон от 0 до 100000.
        /// </exception>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertDoubleOnValue(value, 0, 100000,nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> с указанными названием, описанием и стоимостью.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара</param>
        public Item(string name,Category category, string info, double cost)
        {
            Name = name;
            Category = category;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
        }
        public override string ToString()
        {
            return $"{Id} - {Name} -{Category} - {Info} - {Cost}";
        }
    }
}