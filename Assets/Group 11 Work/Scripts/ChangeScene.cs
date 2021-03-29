using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ReturnButton()
    {
        string place = "Manual Search Screen";
        Go(place);
    }

    public void Plastics()
    {
        string place = "Plastics";
        Go(place);
    }

    public void Bottle()
    {
        string place = "Bottle";
        Go(place);
    }

    public void Container()
    {
        string place = "Container";
        Go(place);
    }

    public void OtherPlastics()
    {
        string place = "OtherPlastics";
        Go(place);
    }

    public void Metal()
    {
        string place = "Metal";
        Go(place);
    }

    public void Glass()
    {
        string place = "Glass";
        Go(place);
    }

    public void Paper()
    {
        string place = "Paper";
        Go(place);
    }

    public void Cardboard()
    {
        string place = "Cardboard";
        Go(place);
    }

    public void Carton()
    {
        string place = "Carton";
        Go(place);
    }

    public void ToGreen()
    {
        string place = "Green Bin";
        Go(place);
    }

    public void ToBlack()
    {
        string place = "Black Bin";
        Go(place);
    }

    public void ToBlue()
    {
        string place = "Blue Bin";
        Go(place);
    }

    public void ToGarbage()
    {
        string place = "Garbage";
        Go(place);
    }

    public void toPlasticsBottle()
    {
        string place = "Plastics Bottle";
        Go(place);
    }

    public void toPlasticsContainer()
    {
        string place = "Plastics Container";
        Go(place);
    }

    public void toPlasticsOther()
    {
        string place = "Plastics Other";
        Go(place);
    }

    public void Go (string place) 
    {
        SceneManager.LoadScene(place);
    }
    
}
