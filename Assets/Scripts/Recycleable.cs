using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycleable
{
    protected string name;
    protected bool recycle; 

    public Recycleable(string name, bool recycle){
        this.name = name;
        this.recycle = recycle; 
    }

    private bool CanRecycle(){
        return recycle;
    }

}
