using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//戦いを管理
//Playre とEnemyを戦わせる。
public class BattleManagerCS : MonoBehaviour
{
    
    //Playserを取得
    public UnitManagerCS player;
    //Enemyを取得する
    public UnitManagerCS enemy;

    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);
    }

    //PlayerがEnemyに攻撃する
    public void OnattackButton()
    {
        player.Attack(enemy);   
        EnemyTurn();
    }

    void EnemyTurn()
    {
        enemy.Attack(player);
    }

}