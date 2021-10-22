using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class VehicleBehavior
    {
        public abstract void AboutMe(string vehicle);
    }
    // Kha nang bay
    class FlyBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine("{0} co the bay ngay bay gio", vehicle);
        }
    }
    // Kha nang boi
    class FloatBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine("{0} co the boi ngay bay gio", vehicle);
        }
    }
    // Khong co chuc nang gi
    class InitialBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine("{0} moi san xuat, chua lam duoc gi", vehicle);
        }
    }

    // Phuong tien
    public class Vehicle
    {
        VehicleBehavior behavior;
        string vehicleType;
        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
            this.behavior = new InitialBehavior();
        }
        // Cai dat hanh vi phuong tien
        public void SetVehicleBehavior(VehicleBehavior behavior)
        {
            this.behavior = behavior;
        }
        public void DisplayAboutMe()
        {
            this.behavior.AboutMe(this.vehicleType);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***DEMO Strategy Pattern***");
            Console.WriteLine();
            Vehicle TOto = new Vehicle("Xe hoi cua T");
            Console.WriteLine("Moi san xuat:");
            TOto.DisplayAboutMe();

            Console.WriteLine("Chuc nang bay:");
            TOto.SetVehicleBehavior(new FlyBehavior());
            TOto.DisplayAboutMe();

            Console.WriteLine("Chuc nang boi:");
            TOto.SetVehicleBehavior(new FloatBehavior());
            TOto.DisplayAboutMe();

            Console.ReadKey();
        }
    }
}
