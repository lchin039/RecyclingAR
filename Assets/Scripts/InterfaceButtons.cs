using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceButtons : MonoBehaviour
{
    public void toSorting()
    {
        SceneManager.LoadScene("Manual Search Screen");
    }

    public void toMenu()
    {
        SceneManager.LoadScene("Unity Project Save 2");
    }
}
