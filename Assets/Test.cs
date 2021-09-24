using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; 
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage+"のダメージを受けた");
        this.hp -= damage;
        Debug.Log("残りの体力は " + this.hp + " だ");
    }

    // ここから発展課題のマジック関数
    public void Magic(int mpCost)
    {
        if (this.mp >= mpCost)
        {
            this.mp -= mpCost;
            Debug.Log("魔法攻撃をした。残りのMPは " + this.mp + "だ。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
    // ここまで発展課題のマジック関数

}
public class Test : MonoBehaviour
{
    void Start()
    {
        // ここから配列の課題
        int[] array = {2, 4, 8, 16, 32};

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = (array.Length-1); i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        // ここまで配列の課題

        Boss lastboss = new Boss ();

        lastboss.Attack();
        lastboss.Defence(39);
        // ここから発展課題の関数呼び出し
        for (int i = 53; i >= 0; i -= 5)
        {
            lastboss.Magic(5);
        }


    }

    void Update()
    {
        
    }
}
