using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Game
{
    public static class Program // класс программ просто вывод
    {
        public static void Main(string[] args)
        {
            // Создаем лучника
            Archer archer = new Archer(1, "Archer", 0, 0, 100, 15);
            
            // Создаем крепость
            Fort fort = new Fort(2, "Fort", 5, 5, true);

            // Создаем передвижной дом
            MobileHome mobileHome = new MobileHome(3, "Mobile Home", 10, 10, true);

            // Выводим информацию о начальном положении лучника
            Console.WriteLine($"Арчер {archer.Name} находится на позиции ({archer.getX}, {archer.getY}) с {archer.GetHp()} HP.");

            // Лучник перемещается
            Console.WriteLine("Арчер перемещается...");
            archer.Movement();
            Console.WriteLine($"Теперь Арчер {archer.Name} находится на позиции ({archer.getX}, {archer.getY}).");

            // Крепость атакует лучника
            Console.WriteLine("Крепость атакует Арчера...");
            fort.Attak(archer);
            Console.WriteLine($"После атаки у Арчера осталось {archer.GetHp()} HP.");

            // Лучник атакует крепость (хотя логика предполагает, что лучник не может атаковать здание)
            Console.WriteLine("Арчер атакует Крепость...");
            archer.Attak(archer); // на самом деле атакует самого себя, так как у здания нет HP

            // Передвижной дом перемещается
            Console.WriteLine("Передвижной дом перемещается...");
            mobileHome.Moveable(archer);  // Хотя здесь логичнее перемещать сам дом, для примера перемещаем юнит
            Console.WriteLine($"Теперь Арчер находится на позиции ({archer.getX}, {archer.getY}).");

            // Проверяем построен ли дом
            Console.WriteLine($"Передвижной дом построен? {mobileHome.getBuilt()}");
        
         
        }
    }
}