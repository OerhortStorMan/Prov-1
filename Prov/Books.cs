using System;
using System.Collections.Generic;

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
            
            //random om den är cursed eller ej
            int isBookCursed = generator.Next(0,100);
            if (isBookCursed <= 20)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }

            //ger en kategori
            List<string> categories = new List<string>(new string[] {"Comedy", "Fiction", "Adventure"});
            int randomCategory = generator.Next(0, 2);
            category = categories[randomCategory];

            int randomTitle;
            if (category == categories[0])
            {
                List<string> comedyTitles = new List<string>(new string[] {"Top 100 jokes", "Evolution of comedy", "Love Winelid: An auto biography"});
                randomTitle = generator.Next(0, 2);
                name = comedyTitles[randomTitle];
                
            }
            else if (category == categories[1])
            {
                List<string> fictionTitles = new List<string>(new string[] {"Star battle", "Space attack", "Surviving mars"});
                randomTitle = generator.Next(0, 2);
                name = fictionTitles[randomTitle];
            }
            else
            {
                List<string> adventureTitles = new List<string>(new string[] {"Jimbiana Whones", "Surviving NTI", "Road to Spain"});
                randomTitle = generator.Next(0, 2);
                name = adventureTitles[randomTitle];
            }






        }

        public void PrintInfo()
        {
            System.Console.WriteLine(@"
            Boken heter" + name +
            /*"Den har " + rarity + " rarity" +*/
            
            "Boken tillhör kategori: " + category 
            /*+ "Boken kostar " + price*/);
            
        }

        public int Evaluate()
        {
            int price = actualValue * rarity;
            
            return price;
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
            int evaluation = generator.Next(0, 100);

            if (evaluation <= 20)
            {
                if (cursed == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (cursed == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
