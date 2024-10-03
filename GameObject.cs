using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Game
{
    public abstract class GameObject //основной абстрактный класс в котором создаем поля
    {
        private int id;
        private string name;
        private int x;
        private int y;
        public GameObject(int id, string name, int x, int y) // создаем конструктор класса
        {
            this.id = id;
            this.name = name;
            this.x = x;
            this.y = y;
        }
        public int ID{ get{ return ID; } } // с 21 - 24 инициализация полей
        public string Name{ get{ return name;}}
        public int getX{ get { return x; }set { x = value; } }
        public int getY{get {return y;}set {y = value;}} 
        public void setPosition(int x,int y){this.x =x;this.y = y; }    // метод для добавляния координат персонажа
    }   
}