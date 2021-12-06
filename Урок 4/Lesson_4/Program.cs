using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var NewBuilding = Creator.CreateBuild(80.5, 460, 30, 4);
            Console.WriteLine(NewBuilding.GetFloorHeight());
            Console.WriteLine(NewBuilding.GetApartmentsOfEntranceNum());
            Console.WriteLine(NewBuilding.GetApartmentsOnFloorNum());

            Creator.CreateBuild(80.5, 460, 30, 4);
            Creator.CreateBuild(80.5, 460, 30, 4);
            Creator.CreateBuild(80.5, 460, 30, 4);

            Console.WriteLine("4 объекта");
            foreach (Building item in Creator.GetTable().Values)
            {
                Console.WriteLine(item.GetNum());
            }

            Creator.RemoveFromTable(3);

            Console.WriteLine("3 объекта");
            foreach (double item in Creator.GetTable().Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
