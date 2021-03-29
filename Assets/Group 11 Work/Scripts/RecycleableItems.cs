using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RecycleableItems 
{
    public static Hashtable build()
    {
        Hashtable Database = new Hashtable();

        Recycleable AerosolAirFreshener = new Recycleable("aerosol air freshener", true, "Bllue Bin");
        Database.Add("aerosol air freshener", AerosolAirFreshener);
        Recycleable AerosolCan = new Recycleable("aerosol can", true, "Blue Bin");
        Database.Add("aerosol can", AerosolCan);
        Recycleable AluminumCan = new Recycleable ("aluminum can", true, "Blue Bin");
        Database.Add("aluminum can", AluminumCan);
        Recycleable AluminumContainer = new Recycleable("aluminum container", true, "Blue Bin");
        Database.Add("aluminum container", AluminumContainer);
        Recycleable aluminumfoil = new Recycleable("aluminum foil", true, "Blue Bin");
        Database.Add("aluminum foil", aluminumfoil);
        Recycleable bakeryPlastics = new Recycleable("bakery plastics", true, "Blue Bin");
        Database.Add("bakery plastics", bakeryPlastics);
        Recycleable BeerbottleCaps = new Recycleable("beer bottle cap", true, "Blue Bin");
        Database.Add("beer bottle cap", BeerbottleCaps);
        Recycleable clearplasticcontiners = new Recycleable("clear plastic container", true, "Blue Bin");
        Database.Add("clear plastic container", clearplasticcontiners);
        Recycleable cookietin = new Recycleable("cookie tin", true, "Blue Bin");
        Database.Add("cookie tin", cookietin);
        Recycleable deodorantspraybottles = new Recycleable("deodorant spray bottle", true, "Blue Bin");
        Database.Add("deodorant spray bottle", deodorantspraybottles);
        Recycleable drinkbox = new Recycleable("drink box", true, "Blue Bin");
        Database.Add("drink box", drinkbox);
        Recycleable frozenjuicecan = new Recycleable("frozen juice can", true, "Blue Bin");
        Database.Add("frozen juice can", frozenjuicecan);
        Recycleable gabletopcontainer = new Recycleable("gable top container", true, "Blue Bin");
        Database.Add("gable top container", gabletopcontainer);
        Recycleable glassbottle = new Recycleable("glass bottle", true, "Blue Bin");
        Database.Add("glass bottle", glassbottle);
        Recycleable hairspray = new Recycleable("hairspray can", true, "Blue Bin");
        Database.Add("hairspray container", hairspray);
        Recycleable icecreamcontainer = new Recycleable("ice cream container", true, "Blue Bin");
        Database.Add("ice cream container", icecreamcontainer);
        Recycleable juicebox = new Recycleable("juice box", true, "Blue Bin");
        Database.Add("juice box", juicebox);
        Recycleable LCBObag = new Recycleable("lcbo bag (paper)", true, "Blue Bin");
        Database.Add("lcbo bag (plastic)", LCBObag);
        Recycleable margarinetubs = new Recycleable("margarine tube", true, "Blue Bin");
        Database.Add("margarine tub", margarinetubs);
        Recycleable metalbottlecap = new Recycleable("metal bottle cap", true, "Blue Bin");
        Database.Add("metal bottle cap", metalbottlecap);
        Recycleable metalcanlid = new Recycleable("metal can lid", true, "Blue Bin");
        Database.Add("metal can lid", metalcanlid);
        Recycleable metalcan = new Recycleable("metal can", true, "Blue Bin");
        Database.Add("metal can", metalcan);
        Recycleable metalpaintcan = new Recycleable("metal paint can", true, "Blue Bin");
        Database.Add("metal paint can", metalpaintcan);
        Recycleable milk = new Recycleable("milk carton", true, "Blue Bin");
        Database.Add("milk carton", milk);
        Recycleable milkbox = new Recycleable("milk box", true, "Blue Bin");
        Database.Add("milk box", milkbox);
        Recycleable plasticjar = new Recycleable("plastic jar", true, "Blue Bin");
        Database.Add("plastic jar", plasticjar);
        Recycleable plasticjug = new Recycleable("plastic jug", true, "Blue Bin");
        Database.Add("plastic jug", plasticjug);
        Recycleable plasticcap = new Recycleable("plastic cap", true, "Blue Bin");
        Database.Add("plastic cap", plasticcap);
        Recycleable plasticbottlecap = new Recycleable("plastic bottle cap", true, "Blue Bin");
        Database.Add("plastic bottle cap", plasticbottlecap);
        Recycleable plasticbottle = new Recycleable("plastic bottle", true, "Blue Bin");
        Database.Add("plastic bottle", plasticbottle);
        Recycleable plasticbucket = new Recycleable("plastic bucket", true, "Blue Bin");
        Database.Add("plastic bucket", plasticbucket);
        Recycleable plasticfoodtrays = new Recycleable("plastic food tray", true, "Blue Bin");
        Database.Add("plastic food tray", plasticfoodtrays);
        Recycleable plasticpail = new Recycleable("plastic pail", true, "Blue Bin");
        Database.Add("plastic pail", plasticpail);
        Recycleable plasticplantingtray = new Recycleable ("plastic planting tray", true, "Blue Bin");
        Database.Add("plastic planting tray", plasticplantingtray); 
        Recycleable plastictuplid = new Recycleable("plastic tub lid", true, "Blue Bin");
        Database.Add("plastic cihp tube", plastictuplid); 
        Recycleable potatochiptub = new Recycleable("potato chip tub", true, "Blue Bin");
        Database.Add("potato chip tube", potatochiptub);
        Recycleable yogurt = new Recycleable("yogurt contianer", true, "Blue Bin");
        Database.Add("yogurt container", yogurt);
        Recycleable can = new Recycleable("pop can", true, "Blue Bin");
        Database.Add("pop can", can);
        Recycleable sourcreamtub = new Recycleable("sour cream tub", true, "Blue Bin");
        Database.Add("sour cream tub", sourcreamtub);
        Recycleable soupbox = new Recycleable("soup box", true, "Blue Bin");
        Database.Add("soup box", soupbox);
        Recycleable steelcan = new Recycleable("steel can", true, "Blue Bin");
        Database.Add("steel can", steelcan);
        Recycleable takeoutclamshell = new Recycleable("take out clam shell", true, "Blue Bin");
        Database.Add("take out clam shell", takeoutclamshell);
        Recycleable takeoutcontainer = new Recycleable("take out container", true, "Blue Bin");
        Database.Add("take out container", takeoutcontainer);
        Recycleable takeoutclearplasticcup = new Recycleable("take out clear plastic cup", true, "Blue Bin");
        Database.Add("take out clear plastic cup", takeoutclearplasticcup);
        Recycleable tetrapaks = new Recycleable("tetra pak", true, "Blue Bin");
        Database.Add("tetra pak", tetrapaks);
        Recycleable tincan = new Recycleable("tin can", true, "Blue Bin");
        Database.Add("tin can", tincan);
        Recycleable whippingcream = new Recycleable("whipping cream bottle", true, "Blue Bin");
        Database.Add("whipping cream bottle", whippingcream);
        Recycleable winebottlecap = new Recycleable("wine bottle cap", true, "Blue Bin");
        Database.Add("wine bottle cap", winebottlecap);
        Recycleable JarLid = new Recycleable("jar lid", true, "Blue Bin");
        Database.Add("jar lid", JarLid);
        Recycleable paintcan = new Recycleable("paint can", true, "Blue Bin");
        Database.Add("paint can", paintcan);
        
        
        
        Recycleable boxboard = new Recycleable("boxboard", true, "Black Bin");
        Database.Add("boxboard", boxboard);
        Recycleable cardboard = new Recycleable("cardboard", true, "Black Bin");
        Database.Add("cardboard", cardboard);
        Recycleable catalogues = new Recycleable("catalogue", true, "Black Bin");
        Database.Add("catalogue", catalogues);
        Recycleable flyer = new Recycleable("flyer", true, "Black Bin");
        Database.Add("flyer", flyer);
        Recycleable folder = new Recycleable("folder", true, "Black Bin");
        Database.Add("folder", folder);
        Recycleable tissuepaper = new Recycleable ("tissue paper", true, "Black Bin");
        Database.Add("tissue paper", tissuepaper);
        Recycleable giftwrappingpaper = new Recycleable("gift wrapping paper", true, "Black Bin");
        Database.Add("gift wrapping paper", giftwrappingpaper);
        Recycleable magazine = new Recycleable("magazine", true, "Black Bin");
        Database.Add("magazine", magazine);
        Recycleable newspaper = new Recycleable("newspaper", true, "Black Bin");
        Database.Add("newspaper", newspaper);
        Recycleable pizzaboxclean = new Recycleable("pizza box (clean)", true, "Black Bin");
        Database.Add("pizza box (clean)", pizzaboxclean);
        Recycleable shreddedpaper = new Recycleable("shredded paper", true, "Black Bin");
        Database.Add("shredded paper", shreddedpaper);
        Recycleable telephonebook = new Recycleable("telephone book", true, "Black Bin");
        Database.Add("telephone book", telephonebook);
        Recycleable tissuebox = new Recycleable("tissue box", true, "Black Bin");
        Database.Add("tissue box", tissuebox);        
        Recycleable book = new Recycleable("book", true, "Black Bin");
        Database.Add("book", book);
        Recycleable paper = new Recycleable("paper", true, "Black Bin");
        Database.Add("paper", paper);
        Recycleable cerealbox = new Recycleable("cereal box", false, "Garbage");
        Database.Add("cereal box", cerealbox);



        Recycleable coffeecup = new Recycleable("coffee cup", true, "Green Bin");
        Database.Add("coffee cup", coffeecup);
        Recycleable papertowel = new Recycleable("paper towel", true, "Green Bin");
        Database.Add("paper towel", papertowel);

        Recycleable cerealboxliner = new Recycleable("cereal box liners", false, "Garbage");
        Database.Add("cereal box liners", cerealboxliner);
        Recycleable candywrappings = new Recycleable("candy wrapping", false, "Garbage"); 
        Database.Add("candy wrapper", candywrappings); 
        Recycleable ceramicplate = new Recycleable("ceramic plate", false, "Garbage");
        Database.Add("ceramic plate", ceramicplate);
        Recycleable windowpane = new Recycleable("window pane", false, "Garbage");
        Database.Add("window pane", windowpane);
        Recycleable styrofoam = new Recycleable("styrofoam", false, "Garbage");
        Database.Add("styrofoam", styrofoam);
        Recycleable plasticcups = new Recycleable("plastic cup", false, "Garbage");
        Database.Add("plastic cup", plasticcups);
        Recycleable plastictoy = new Recycleable("plastic toy", false, "Garbage");
        Database.Add("plastic toy", plastictoy);

        return Database;

    }
}
