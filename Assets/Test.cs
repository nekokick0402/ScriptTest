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
        if (this.mp <= this.cost)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            Debug.Log("魔法攻撃をした。残りmpは" + this.mp + "。");
        }
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();
        for (int i = 0; i < 13; i++)
        {
        lastboss.Magic();
        }
    }
}