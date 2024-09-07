using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        readonly int _id;
        private string _name;
        private string _info;
        private double _cost;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length>200)
                {
                    throw new ArgumentException("Название товара не должно превышать 200 символов");
                }
                _name = value;
            }
        }
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                if (value.Length>1000)
                {
                    throw new ArgumentException("Описание товара не должно превышать 1000 символов");
                }
                _info = value;
            }
        }
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value>1000000 || value < 0 )
                {
                    throw new ArgumentException("Цена должна быть в диапазоне от 0 до 1000");
                }
                _cost = value;
            }
        }
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
        }
    }
}
