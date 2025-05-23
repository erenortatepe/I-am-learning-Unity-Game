using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [Header("Managers")]
    public Player player;
    public EnemyManager enemyManager;
    public LevelManager levelManager;

    private void Start()
    {
        RestartLevel();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        levelManager.RestartLevel();
        enemyManager.RestartEnemyManager();
        player.RestartPlayer();
    }

    public void LevelCompleted()
    {
        enemyManager.StopEnemies();
    }
}
