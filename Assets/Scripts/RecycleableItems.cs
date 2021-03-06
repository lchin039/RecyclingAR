using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RecycleableItems 
{
    public static Hashtable build()
    {
        Hashtable Database = new Hashtable();
        Recycleable paper = new Recycleable("paper", true, "Paper Recycle");
        Database.Add("paper", paper);

        Recycleable glass = new Recycleable("glass", true, "Blue Bin");
        Database.Add("glass", glass);
        Recycleable can = new Recycleable("can", true, "Blue Bin");
        Database.Add("can", can);
        Recycleable JarLid = new Recycleable ("jar lid", true, "Blue Bin");
        Database.Add("jar lid", JarLid);
        Recycleable paintcan = new Recycleable("paint can", true, "Blue Bin");
        Database.Add("paint can", paintcan);
        Recycleable hairspray = new Recycleable("hairspray can", true, "Blue Bin");


        return Database;
    }
}
