using System.Collections;

namespace Lesson_4
{
    public class Creator
    {
        private static Hashtable Table = new Hashtable();
        private Creator() { }

        public static Building CreateBuild(double Height, int ApartmentsNum, int FloorsNum, int EntrancesNum)
        {
            var building = new Building(Height, ApartmentsNum, FloorsNum, EntrancesNum);
            Table.Add(building.GetNum(), building);
            return building;
        }

        public static void RemoveFromTable(double KeyNum)
        {
            Table.Remove(KeyNum);
        }
        public static Hashtable GetTable()
        {
            return Table;
        }
    }
}
