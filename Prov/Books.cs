using System;

namespace Prov
{
    public class Books
    {
        public int price;
        string name;
        int rarity;
        string category;
        int actualValue;
        bool cursed;

        Random generator = new Random();

        public void Book()
        {
            int curseTest = generator.Next(0,100);
            if (curseTest <= 20)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }
        }

        public void PrintInfo()
        {

        }

        public int Evaluate()
        {
            return 0;
        }

        public string GetCategory()
        {
            return "";
        }

        public string GetName()
        {
            return "";
        }

        public bool IsCursed()
        {
            return false;
        }
    }
}
