namespace Game
{
    public class Fort : Building, Attaker// класс форт наследует интерфейс + класс билдинг
    {
        public Fort(int id, string name, int x, int y , bool built) : base(id, name, x, y, built)
        {// конструктор класса
            
        }
         public void Attak(Unit unit) // реализовываем интерфейс
        {
            unit.receiveDamage();
        }
    }
}