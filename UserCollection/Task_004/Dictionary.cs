using System.Collections;
using System.Collections.Generic;

namespace Task_004
{
    public class Dictionary
    {
        private Pairs[] _pairses;

        private int _position;

        public Dictionary()
        {
            _pairses = new Pairs[5];

            for (var i = 0; i < _pairses.Length; i++)
            {
                _pairses[i] = new Pairs();
            }
        }

        public int Count => _position;

        public void Add(string key, string fValue, string sValue)
        {
            if (_position >= _pairses.Length)
            {
               var temp = new Pairs[_pairses.Length * 2];
               _pairses.CopyTo(temp, 0);
               _pairses = temp;
            }
            
            _pairses[_position].Key = key;
            _pairses[_position].FValue = fValue;
            _pairses[_position].SValue = sValue;

            _position++;
        }

        public string this[string key, string format]
        {
            get
            {
                for (var i = 0; i < _pairses.Length; i++)
                {
                    if (key == _pairses[i].Key)
                    {
                        if (format == "ru")
                        {
                            return _pairses[i].FValue;
                        }
                        else if (format == "en")
                        {
                            return _pairses[i].SValue;
                        }
                    }
                }

                return null;
            }
        }
    }
}