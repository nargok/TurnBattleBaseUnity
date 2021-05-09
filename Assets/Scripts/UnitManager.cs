using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    // ステータス
    public int hp;
    public int at;

    // 攻撃関数
    public void Attack(UnitManager target)
    {
       target.Damage(at); 
    }

    // ダメージ関数
    void Damage(int damage)
    {
        hp -= damage;
        Debug.Log(name + "は" + damage + "のダメージを受けた");
        // Debug.Log(string.Format("{1}は{2}ダメージを受けた", name, damage.ToString()));
    }

}
