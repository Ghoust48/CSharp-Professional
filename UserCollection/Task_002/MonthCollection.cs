using System;
using System.Collections;
using System.Linq;

namespace Task_002
{
    public class MonthCollection : IEnumerable, IEnumerator
    {
        private string[] _names = 
        {
            "Январь", "Фервраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь",
            "Декабрь"
        };

        private int[] _nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

        private int[] _days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        private int _position = -1;
        
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            while (_position < _nums[_nums.Length - 1])
            {
                _position++;
                return true;
            }
            
            Reset();
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object? Current => $"{_days} - {_names} - {_nums}";

        public string NumByMonths(int num)
        {
            for (var i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] == num)
                {
                    return $"{_days[i]} - {_names[i]} - {_nums[i]}";
                }
            }

            return null;
        }
        
        public string DaysByMonths(int day)
        {
            var tmp = "";
            
            for (var i = 0; i < _nums.Length; i++)
            {
                if (_days[i] == day)
                {
                    tmp += $"{_days[i]} - {_names[i]} - {_nums[i]}\n";
                }
            }

            return tmp;
        }
    }
}