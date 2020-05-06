using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("월 입력: ");
            String month = Console.ReadLine();
            if (month.Contains("3"))
            {
                Console.WriteLine("봄입니다.");
            }
            else if (month.Contains("4"))
            {
                Console.WriteLine("봄입니다.");
            } else if (month.Contains("5"))
            {
                Console.WriteLine("봄입니다.");
            }

            else if (month.Contains("6"))
            {
                Console.WriteLine("여름입니다.");
            }
            else if (month.Contains("7"))
            {
                Console.WriteLine("여름입니다.");
            }
            else if (month.Contains("8"))
            {
                Console.WriteLine("여름입니다.");
            }

            else if (month.Contains("9"))
            {
                Console.WriteLine("가을입니다.");
            }
            else if (month.Contains("10"))
            {
                Console.WriteLine("가을입니다.");
            }
            else if (month.Contains("11"))
            {
                Console.WriteLine("가을입니다.");
            }

            else if (month.Contains("12"))
            {
                Console.WriteLine("겨울입니다.");
            }
            else if (month.Contains("1"))
            {
                Console.WriteLine("겨울입니다.");
            }
            else if (month.Contains("2"))
            {
                Console.WriteLine("겨울입니다.");
            }
            else
            {
                Console.WriteLine("잘못 입력했다.");
            }

        }
    }
}
