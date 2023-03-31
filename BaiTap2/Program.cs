using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Moi ban nhap so N: ");
            //int n = int.Parse(Console.ReadLine());

            //int i = 1;
            //int tinh = 0;

            //for(i=1; i<=n; i++)
            //{
            //    tinh = i * n;
            //    //Console.WriteLine("Bang cuu chuong:{0}",tinh);
            //    Console.WriteLine($"Bang cuu chuong: {n} * {i} = {tinh}\n");

            //}
            //Console.ReadKey();

            //static void Main(string[] args)
            //{
            //    int y = 10;
            //    int a = 2;
            //    int b = 4;

            //    int x = PhuongThuc.Tinh_Tong(a, b, y);

            //    Console.WriteLine(x);

            //    int f = PhuongThuc.Tinh_Hieu(a, b, y);
            //    Console.WriteLine("Hieu cua a,b,y la: {0}", f);
            //    PhuongThuc.Hello();

            //    string fullName;
            //    fullName = PhuongThuc.FullName(ho: "Nguyen", ten: "Nguyen", tenDem: "Giang");
            //    Console.WriteLine(fullName);
            //}

            Console.Write("Moi ban nhap so N: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int tinh = 0;
            //int cuuChuong = PhuongThuc.Tinh_Toan(n,i);

            for (i = 1; i <= 10; i++)
            {
                
                tinh = i * n;
                //Console.WriteLine("Bang cuu chuong:{0}",tinh);
                //Console.WriteLine($"{n} * {i} = {cuuChuong}\n");
                Console.WriteLine($"Bang cuu chuong: {n} * {i} = {tinh}\n");

                
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
