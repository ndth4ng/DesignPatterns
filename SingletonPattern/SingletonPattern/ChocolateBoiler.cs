using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        // Tạo một instance duy nhất
        private static ChocolateBoiler uniqueInstance;

        // Triển khai một private constructor để ngăn các lớp khác khai báo nhiều hơn một instance.
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        // Khởi tạo phương thức static để có thể truy xuất đến phương thức này từ bất cứ nơi nào
        public static ChocolateBoiler getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            // Không tạo thêm mà chỉ trả về một instance duy nhất
            return uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Fill the boiler with milk/chocolate mixture");
            }
            else
            {
                Console.WriteLine("The boiler is already filled!");
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {               
                empty = true;
                Console.WriteLine("Drain the boiler");
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                boiled = true;
                Console.WriteLine("Boiled the mixture");
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }

        public bool IsBoiled()
        {
            return boiled;
        }
    }
}
