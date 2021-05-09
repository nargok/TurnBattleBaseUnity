using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public void OnAttachButton()
    {
        player.Attack(enemy);
        EnemyTurn();
    }
    // EnemyがPlayerを攻撃する
    void EnemyTurn()
    {
        enemy.Attack(player);
    }

}
