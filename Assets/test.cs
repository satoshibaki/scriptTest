using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
    void Start()
    {
        //要素数5の配列を初期化する
        int[] array = new int[5];

        //配列の各要素に値を代入する
        array[0] = 30;
        array[1] = 20;
        array[2] = 40;
        array[3] = 60;
        array[4] = 80;

        //配列の要素をすべて表示する(順番)
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の要素をすべて表示する（逆順）
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }
}

public class Boss
{
    private int mp = 53; // 魔法ポイント

    //魔法攻撃の関数および残魔法ポイントの関数
    public void MagicAttack()
    {
        Debug.Log("魔法攻撃をした" );
    }
    for (int i = 53; i >= 5; i -= 5)
    {
        Debug.Log("残りのMPは" + i);
    }
    
}

public class test : MonoBehaviour
{
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 魔法攻撃の関数および残魔法ポイントの関数

        if (i >= 5)
        {
            lastboss.MagicAttack();
        }
        else if (i < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
