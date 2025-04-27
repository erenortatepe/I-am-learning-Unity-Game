using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [Header("Managers")]
    public EnemyManager enemyManager;
    public LevelManager levelManager;

    private void Start()
    {
        RestartLevel();
    }

    private void RestartLevel()
    {
        levelManager.RestartLevel();
        enemyManager.RestartEnemyManager();
    }

    public void LevelCompleted()
    {
        enemyManager.StopEnemies();
    }
}
