using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputToText : MonoBehaviour
{
    public InputField SearchItem;
    public Text output;
    public void getText()
    {
        string Item = SearchItem.text;
        output.text = Item;
    }

    public static string hi(string item)
    {
        string isRecycleable = "no"; 
        string thing = item.ToLower();

        return isRecycleable;
    }

}
