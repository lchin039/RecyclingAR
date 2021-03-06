using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycleable
{
    protected string name;
    protected bool recycle; 
    protected int scene;

    public Recycleable(string name, bool recycle){
        this.name = name;
        this.recycle = recycle; 
    }

    public bool CanRecycle(){
        return recycle;
    }
    public int GetScene(){
        return scene;
    }

}
