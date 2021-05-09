using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    // Playerを取得する
    public UnitManager player;
    // Enemyを取得する
    public UnitManager enemy;
    
    void Start()
    {
    }
    
    // playerがEnemyを攻撃する
    public void OnAttackButton()
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
    // EnemyがPlayerを攻撃する
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
        Debug.Log("対戦終了");
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);

    }

}
