using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;
    private int cost = 5;

    public void Magic()
    {
        this.mp -= this.cost;
        Debug.Log("魔法攻撃をした。残りmpは" + this.mp + "。");
        if(this.mp <= this.cost)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();
        for (int i = 0; i < 10; i++)
        {
        lastboss.Magic();
        }
    }
}