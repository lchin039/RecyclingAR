using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RecycleableItems 
{
    public static Hashtable build()
    {
        Hashtable Database = new Hashtable();

        Recycleable glass = new Recycleable("glass", true, "Blue Bin");
        Database.Add("glass", glass);
        Recycleable can = new Recycleable("can", true, "Blue Bin");
        Database.Add("can", can);
        Recycleable JarLid = new Recycleable("jar lid", true, "Blue Bin");
        Database.Add("jar lid", JarLid);
        Recycleable paintcan = new Recycleable("paint can", true, "Blue Bin");
        Database.Add("paint can", paintcan);
        Recycleable hairspray = new Recycleable("hairspray can", true, "Blue Bin");
        Database.Add("hairspray container", hairspray);
        Recycleable yogurt = new Recycleable("yogurt contianer", true, "Blue Bin");
        Database.Add("yogurt container", yogurt);
        Recycleable milk = new Recycleable("milk carton", true, "Blue Bin");
        Database.Add("milk carton", milk);
        Recycleable juicebox = new Recycleable("juice box", true, "Blue Bin");
        Database.Add("juicebox", juicebox);
        Recycleable aluminumfoil = new Recycleable("aluminum foil", true, "Blue Bin");
        Database.Add("aluminum foil", aluminumfoil);

        Recycleable book = new Recycleable("book", true, "Black Bin");
        Database.Add("book", book);
        Recycleable paper = new Recycleable("paper", true, "Black Bin");
        Database.Add("paper", paper);

        Recycleable coffeecup = new Recycleable("coffee cup", true, "Green Bin");
        Recycleable papertowel = new Recycleable("paper towel", true, "Green Bin");

        Recycleable cerealbox = new Recycleable("cereal box", false, "Garbage");
        Recycleable candywrappings = new Recycleable("candy wrapping", false, "Garbage"); 
        return Database;

    }
}
