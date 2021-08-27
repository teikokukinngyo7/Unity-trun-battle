using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
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

    }

    //PlayerがEnemyに攻撃する
    public void OnattackButton()
    {
        player.Attack(enemy);   
        if (enemy.hp > 0)
        {
            EnemyTurn();
        }
        else
        {
            BattleEnd();
        }
    }

    void EnemyTurn()
    {
        enemy.Attack(player);
        if (player.hp == 0)
        {
            BattleEnd();
        }
    }

    void BattleEnd()
    {
        Debug.Log("ゲーム終了");
        //現在のシーン名を取得
        string currentScene = SceneManager.GetActiveScene().name; 
        
        //現在のシーンを再読み込み
        SceneManager.LoadScene(currentScene);

    }

}