using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandLineArgs
{
    class Program
    {
        static void Print(string _Name, string _Order)
        {
            if (_Order == "-")
            {
                for (int i = _Name.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(_Name[i]);
                }
            }
            else
            {
                for (int i = 0; i < _Name.Length; i++)
                {
                    Console.WriteLine(_Name[i]);
                }
            }
        }
        static void AskQuestion(string _Text,ref string _Input)
        {
            Console.WriteLine(_Text);
            _Input = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string _Name = " ", _Order = " ";
            string _AskName = "Как вас зовут?";
            string _AskOrder = "Как ввывести ваше имя? ( \"-\" обратный порядок)";
            try
            {
                _Name = args[0];
                _Order = args[0];
            }
            catch
            {
                AskQuestion(_AskName, ref _Name);
                AskQuestion(_AskOrder, ref _Order);
            }
            finally
            {
                Print(_Name, _Order);
            }
            /*if (args.Length >= 2)
            {
                _Name = args[0];
                _Order = args[1];
            }
            else
            {
                if (args.Length >= 1)
                {
                    _Name = args[0];
                    AskQuestion(_AskOrder, ref _Order);
                    
                }
                else
                {
                    AskQuestion(_AskName, ref _Name);
                    AskQuestion(_AskOrder, ref _Order);
                }
            }
            Print(_Name, _Order);
            */
        }
    }
}
