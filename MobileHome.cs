namespace Game
{
    public class MobileHome : Building,Moveable // наследуем интерфейс + класс билдинг
    {
        public MobileHome(int id, string name, int x, int y , bool built) : base(id, name, x, y, built)
        {} // конструктор
        public void Moveable(Unit unit) // реализовываем интерфейс передвижения
        {
            unit.Movement();
        }
    }
}