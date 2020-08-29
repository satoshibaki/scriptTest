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

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // Magic関数を10回使う。魔法攻撃の関数および残魔法ポイントの関数を呼び出し

        for (int u = 0; u <= 10; u++)
            {
                lastboss.MagicAttack();
            }
    }
}

public class Boss
{
    private int mp = 53; // 魔法ポイント
    private int mup; // 残りの魔法ポイント

    //魔法攻撃の関数および残魔法ポイントの関数
    public void MagicAttack()
    {
        mup = mp -= 5;

        if (mup >= 0)
        {
            Debug.Log("魔法攻撃をした。残りのMPは" + mup);
        }
        else if (mup < 0)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}