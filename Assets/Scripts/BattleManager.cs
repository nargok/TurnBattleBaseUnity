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
        player.Attack(enemy);
        enemy.Attack(player);
    }
    
    // playerがEnemyを攻撃する
    // EnemyがPlayerを攻撃する

}
