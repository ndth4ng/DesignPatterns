﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Android android = new Android();
            Iphone iPhone = new Iphone();

            Console.WriteLine("Recharging android with MicroUsb");
            rechargeMicroUsbPhone(android);

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Recharging iPhone with Lightning");
            rechargeLightningPhone(iPhone);

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Recharging iPhone with MicroUsb");
            rechargeMicroUsbPhone(new LightningToMicroUsbAdapter(iPhone));

            Console.ReadKey();
        }

        static void rechargeMicroUsbPhone(MicroUsbPhone phone)
        {
            phone.useMicroUsb();
            phone.recharge();
        }

        static void rechargeLightningPhone(LightningPhone phone)
        {
            phone.useLightning();         
            phone.recharge();

        }
    }
}
