using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03面向对象__属性
{
    class Man
    {
        private string _name;
        private int _age;
        private char _gender;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set {
                if (value < 0 || value > 99)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        public char Gender
        {
            get { return _gender; }
            set {
                if (value != '男' && value != '女')
                {
                    value = '妖';
                }
                _gender = value;
            }
        }

        public void Hobby()
        {
            Console.WriteLine("我叫{0}，性别{1}，今年{2}岁", Name, Gender, Age);
        }
    }
}
