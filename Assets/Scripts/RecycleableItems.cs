using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RecycleableItems 
{
    public static Hashtable build()
    {
        Hashtable Database = new Hashtable();
        Recycleable paper = new Recycleable("paper", true);
        Database.Add("paper", paper);
        return Database;

    }
}
