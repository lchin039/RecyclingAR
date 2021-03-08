using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputToText : MonoBehaviour
{
    public InputField SearchItem;
    public Text output;

    private void Start() {
        RecycleableDatabase.create();
    }

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
    Takes in the name and prints out a if the item is not recycleable
    If the item is recycleable, switches scenes to the item's recycling scene
    */
    public static string IsRecycleable(string name)
    {
        string isRecycleable = "Item is NOT recycleable"; 
        string thing = name.ToLower();
        string destination;
        Recycleable item = RecycleableDatabase.Search(thing);

        if(item != null)
        {
            destination = item.GetScene();
            isRecycleable = "";
            try
            {
                SceneManager.LoadScene(destination);
            }
            catch (System.Exception)
            {
                
                isRecycleable = "error";
            }

        }

        return isRecycleable;
    }

}
