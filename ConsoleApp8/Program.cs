using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystals;
            int priceUnitCrystal = 10;
            int remainingGold;

            Console.WriteLine("Добро пожаловать в наш магазин кристаллов.Сегодня кристаллы по " + priceUnitCrystal + " золота.");
            Console.Write("Скажите, сколько у вас золота: ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Скажите, сколько кристаллов вы хотите купить: "); 
            crystals = Convert.ToInt32(Console.ReadLine());

            remainingGold = gold - crystals * priceUnitCrystal;
            Console.WriteLine($"У вас теперь кристаллов {crystals}, остатаок золотв {remainingGold}. Приятно было иметь с вами дело!");
        }
    }
}
