using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Title, Playing, Paused, GameOver
}
public enum Difficulty
{
    Easy, Medium, Hard
}

public class GameManager : Singleton<GameManager>
{
    public GameState gameState;
    public Difficulty difficulty;
    public int score;
    public int scoreMultiplier = 1;

    void SetUp()
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                scoreMultiplier = 1;
                break;
            
            case Difficulty.Medium:
                scoreMultiplier = 2;
                break;

            case Difficulty.Hard:
                scoreMultiplier = 3;
                break;

        }
    }

    public void AddScore(int _score)
    {
        score = _score * scoreMultiplier;
    }

    private void OnEnable()
    {
        Enemy.OnEnemyHit += OnEnemyHit;
        Enemy.OnEnemyDie += OnEnemyDie;
    }

    private void OnDisable()
    {
        Enemy.OnEnemyHit -= OnEnemyHit;
        Enemy.OnEnemyDie -= OnEnemyDie;
    }

    void OnEnemyHit(GameObject _enemy)
    {
        AddScore(10);
    }
    void OnEnemyDie(GameObject _enemy)
    {
        AddScore(100);
    }
}
