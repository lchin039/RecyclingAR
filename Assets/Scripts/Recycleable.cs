using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycleable
{
    protected string name;
    protected bool recycle; 
    protected string scene;

    public Recycleable(string name, bool recycle, string scene){
        this.name = name;
        this.recycle = recycle; 
        this.scene = scene;
    }

    public bool CanRecycle(){
        return recycle;
    }
    public string GetScene(){
        return scene;
    }

}
