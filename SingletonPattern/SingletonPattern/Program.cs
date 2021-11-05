using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Không thể tạo bằng new ( = new ChocolateBoiler()) vì constructor khởi tạo là private
            // Lấy đối tượng thông qua phương thức getIntance();
            ChocolateBoiler boiler = ChocolateBoiler.getInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.getInstance();

            Console.WriteLine("isEmpty: {0} ", boiler.IsEmpty());
            boiler.Fill();

            Console.WriteLine("===========================================");
            
            // Vì là một đối tượng duy nhất nên IsEmpty đã bị thay đổi thành False sau phương thức Fill() của boiler1
            Console.WriteLine("isEmpty: {0}", boiler2.IsEmpty());
            boiler2.Fill();

            Console.WriteLine("===========================================");

            // Boiler 1
            boiler.Boil();

            Console.WriteLine("===========================================");

            // Boiler 2
            boiler2.Drain();

            Console.ReadKey();
        }
    }
}
