using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiTap4;

namespace BaiTap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap so nguyen N: ");
            int n = int.Parse(Console.ReadLine());

            bool soChinhphuong = PhuongThucSoChinhPhuong.soCP(n);

            if (soChinhphuong)
            {
                Console.WriteLine("la so chinh phuong {0}",soChinhphuong);
            }
            else
            {
                Console.WriteLine("Khong phai la so chinh phuong {0}",soChinhphuong);
            }
            Console.ReadKey();

            // Hàm kết thúc chương trình bằng phím Esc
            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey();
                Console.Write(" --- You pressed ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
