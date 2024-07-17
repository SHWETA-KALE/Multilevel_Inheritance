using static MultiLevelInheritanceDemo.models.MultiLevel;

namespace MultiLevelInheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City myCity = new City();
            myCity.Name();
            myCity.Capital();
            myCity.Food();
        }
    }
}
