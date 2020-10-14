using System;
using System.Collections.Generic;

namespace Prov
{
    public class Customer
    {
        //en lista med olika namn på köpare som kommer
        List<string> nameList = new List<string>();
        string name;

        //pengar som kunderna kan handla för
        public int money;

        //intresse för produkten som kunden har
        int interest;
        
        Random generator = new Random();

        //metod där kunden kommer att evaluatea produkten för att se om hen är intresserad
        public void ItemEvaluate()
        {

        } 

    }
}
