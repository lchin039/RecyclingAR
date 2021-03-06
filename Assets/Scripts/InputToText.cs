using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputToText : MonoBehaviour
{
    public InputField SearchItem;
    public Text output;

    /*
    Laura Chin
    void -> void
    retreives the item in the search bar and prints out the output
    */
    public void getText()
    {
        string item = SearchItem.text;
        output.text = IsRecycleable(item);
    }

    /*
    Laura Chin
    String -> String
    Takes in the name and prints out a if the item is recycleable
    */
    public static string IsRecycleable(string name)
    {
        string isRecycleable = "Item is NOT recycleable"; 
        string thing = name.ToLower();
        Recycleable item = RecycleableDatabase.Search(thing);

        if(item != null && item.CanRecycle() == true)
        {
            isRecycleable = "Item IS recycleable";

        }

        return isRecycleable;
    }

}
