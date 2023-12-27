using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    internal class Money
    {
        public int _uah;
        public int _kop;

        public int Uah
        {
            get
            {
                return _uah;
            }

            set
            {
                if (value >= 0)
                {

                    _uah = value;

                }
            }
        }
        public int Kop
        {
            get
            {
                return _kop;
            }

            set
            {
                if (value >= 0)
                {
                    _kop = value;
                    if (value >= 100)
                    {
                        var intpart = value / 100;
                        _uah += intpart;
                        intpart *= 100;
                        _kop = value - intpart;

                    }
                    
                    
                }
            }
        }
        public static void SettingValue()
        {
            Console.Write("Hello! Enter the amount of hryvnia: ");
            var IsGrn = int.TryParse(Console.ReadLine(), out int _uah);
            if (IsGrn == false)
            {
                throw new Exception("Sorry, enter the number");
            }
            Console.Write("Enter the amount of kopecks: ");
            var IsKop = int.TryParse(Console.ReadLine(), out int _kop);
            Sum(_uah, _kop);
        }
        public static void Sum(int _uah, int _kop)
        {

            
            Console.WriteLine($"The sum is {_uah} grn {_kop} kop");
        }
    }
}
