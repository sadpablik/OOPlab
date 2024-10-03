using System.Runtime.CompilerServices;

namespace Game
{
    
    public abstract class Building : GameObject // класс билдинг он абстрактый и мы наследуем класс геймобжект к слову почитай про 4 столпа ооп и все поймешь
    {
        private bool built; // создаем поле для проверки
        public Building(int id, string name, int x, int y , bool built) : base( id, name, x,y) 
        { // конструктор
            this.built = built;
        }
        public bool getBuilt(){ return built; } // инициализация поля
        
    }
}