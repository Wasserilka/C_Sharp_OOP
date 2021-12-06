namespace Lesson_4
{
    public class Building
    {
        private int Num;
        private double Height;
        private int FloorsNum;
        private int ApartmentsNum;
        private int EntrancesNum;
        private static int NumCounter = 0;

        private void GenerateNum()
        {
            NumCounter++;
            Num = NumCounter;
        }
        public double GetNum()
        {
            return Num;
        }
        public void SetHeight(double Height)
        {
            this.Height = Height;
        }
        public double GetHeight()
        {
            return Height;
        }
        public void SetFloorsNum(int FloorsNum)
        {
            this.FloorsNum = FloorsNum;
        }
        public int GetFloorsNum()
        {
            return FloorsNum;
        }
        public void SetApartmentsNum(int ApartmentsNum)
        {
            this.ApartmentsNum = ApartmentsNum;
        }
        public int GetApartmentsNum()
        {
            return ApartmentsNum;
        }
        public void SetEntrancesNum(int EntrancesNum)
        {
            this.EntrancesNum = EntrancesNum;
        }
        public int GetEntrancesNum()
        {
            return EntrancesNum;
        }
        public double GetFloorHeight()
        {
            return Height / FloorsNum;
        }
        public int GetApartmentsOfEntranceNum()
        {
            return ApartmentsNum / EntrancesNum;
        }
        public int GetApartmentsOnFloorNum()
        {
            return ApartmentsNum / FloorsNum;
        }

        internal Building(double Height, int ApartmentsNum, int FloorsNum, int EntrancesNum)
        {
            this.Height = Height;
            this.FloorsNum = FloorsNum;
            this.ApartmentsNum = ApartmentsNum;
            this.EntrancesNum = EntrancesNum;
            GenerateNum();
        }
    }
}
