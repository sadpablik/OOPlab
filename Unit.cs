using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Game
{
    public abstract class Unit : GameObject // второй основной абстрактный класс, который наследуют себя класс gameobject
    { // создаем поля
        private float hp;
        private float damage;
        public Unit(int id, string name, int x, int y,float hp, float damage) : base(id, name,x,y) 
        { // 12 - конструктор base - наследование для конструктора
            this.hp = hp;
            this.damage = damage;
        }
        public float GetHp() // инициализация полей
        {
            return hp;
        }
        public bool IsAlive() // проверяем жив ли персонаж или нет
        {
            if (hp>0) {return true;}
            else {return false;}
        }
        public void receiveDamage() // метод на получение демеджа 
        {
            hp = hp-damage;
            Console.WriteLine($"Оставшееся хп:{hp}, Нанесенный дамаг: {damage}");
        }
        public void Movement() // метод для передвижения
        {
            getX = getX+10;
            getY=getY+10;
        } 
    }
}