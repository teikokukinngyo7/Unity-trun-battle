using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//キャラクターを管理する。
public class UnitManagerCS : MonoBehaviour
{
    //ステータス
    public int hp;

    public int at;
    //攻撃関数
    public void Attack(UnitManagerCS target)
    {
        target.Damage(at);
    }

    //ダメージ関数
    void Damage(int damage)
    {
        hp -= damage;
        Debug.Log(name+"は"+damage+"ダメージをうけた");
    }
}
