using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Websites : MonoBehaviour
{

    public static void OurSite()
    {
        Application.OpenURL("shair086.wixsite.com/areyourecycling");
    }

    public void uOttawa()
    {
        Application.OpenURL("https://www.uottawa.ca/en");
    }

    public void Ottawa()
    {
        Application.OpenURL("https://ottawa.ca/en/garbage-and-recycling/recycling");
    }

    public void TerraCycle()
    {
        Application.OpenURL("https://www.terracycle.com/en-CA/");
    }

    public void GlobalNews()
    {
        Application.OpenURL("https://globalnews.ca/tag/recycling-in-canada/");
    }


}