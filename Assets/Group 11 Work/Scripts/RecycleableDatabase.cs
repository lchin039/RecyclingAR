using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RecycleableDatabase
{ 
        public static Hashtable Database = new Hashtable(); //creates the database

        public static void create() {
           Database = RecycleableItems.build();
        }

        /*
        Laura Chin
        string -> Recycleable 
        Returns the item associated with the inputed name or returns null is the item is not in the database
        */
        public static Recycleable Search(string key) 
        {
            //Database = RecycleableItems.build();
            try
            {
                Recycleable item = (Recycleable) Database[key];     
                return item;           
            }
            catch 
            {
                
                return null;
            }

        }

        public static List<string> getKeys()
        {
            ICollection stepOne =  Database.Keys;
            List<string> keys = new List<string>();
            foreach(var i in stepOne)
            {
                keys.Add(i.ToString());
            }
            return keys;
        }
        

}
