using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleableDatabase : MonoBehaviour
{
    Recycleable[] Database = new Recycleable[1]; 
    
    Recycleable can = new Recycleable("Can", true);

    private void add ()
    {
        int size = 2;
        print(size);
    }
}
