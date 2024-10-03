using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Game
{
    public interface Attaker // первый интерфейс - это нужно почитать про полиморфизм и интерфейсы и тогда поймешь
    {
        void Attak(Unit unit);
        
    }
    public interface Moveable // тоже самое только для передвежения 
    {
        void Moveable(Unit unit);
    }
    public class Archer : Unit,Attaker,Moveable // класс лучник он наследует два интерфейса и класс юнит про наследование тоже к слову нужно почитать бы
    {
         public void Attak(Unit unit) // это мы реализовываем интерфейс
        {
            unit.receiveDamage();
        }
        public void Moveable(Unit unit) // также
        {
            unit.Movement();
        }
        public Archer(int id, string name, int x, int y,float hp, float damage) : base(id, name,x,y,hp,damage) 
        {//создали конструктор класса
        }
    }


}