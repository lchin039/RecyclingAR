using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputToText : MonoBehaviour
{
    public InputField SearchItem;
    public Text output;
    public Dropdown listofChoices;
    private List<Dropdown.OptionData> listoptions;
    private List<string> keys;

    /*
    Laura Chin
    void -> void
    creates the database when the project first starts
    */
    private void Start() {
        RecycleableDatabase.create();
        keys = RecycleableDatabase.getKeys(); //Creates a list of all keys in database
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
    //Try to make something that will list out possible choices from the database
    public void guessItem()
    {
        int length;
        string Item = SearchItem.text;
        Item.ToLower().Trim();
        length = Item.Length; 
        List<string> things = new List<string>();
        foreach(string i in keys)
        {
            if(i.Contains(Item))
            {
                things.Add(i);
            }
        }

        if(things.Count > 0)
        {
            string outPutText = "";
            foreach(string i in things)
            {
                outPutText = outPutText + i + System.Environment.NewLine;
            }
            output.text = outPutText;

        }
        if(length <1)
        {
            output.text = "";
        }

    }

}