using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //Using square brackets, it calls in an array. 
    public Transform[] spawnPoints;     //Contains the amount of spawnpoints
    public List<GameObject> enemies;    //Contains all the enemies in the scene
    public GameObject[] enemyTypes;     //Contains Enemy Types
    public string[] enemyNames;

    void Start()
    {
        //don't forget to put the square brackets to call the actual array. print(enemyNames); will only print the first part telling us what it is.

        /*print(EnemyNames[EnemyNames.Length - 1]);
        print(Enemies.Count);
        print(Enemies[1].name);*/

        //.Length to call the length of the array however it will be out of the range. Most commonly use the length - 1.
        //Most efficient way of coding is to bake the code as small as possible

        /*enemies.Add(enemyTypes[0]);
        enemies.Add(enemyTypes[1]);
        enemies.Add(enemyTypes[2]);
        enemies.Add(enemyTypes[3]);
        enemies.Add(enemyTypes[4]);
        enemies.Add(enemyTypes[5]);*/
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            SpawnEnemy();
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            KillEnemy();
        }
    }

    void SpawnEnemy()
    {
        //Random.Range to get a random range (<Minimum>, <Maximum>)
        //Spawns an enemy. (<The object>, <the position>)
        int enemyNumber = Random.Range(0, enemyNames.Length);
        int spawnPoint = Random.Range(0, spawnPoints.Length);
        GameObject enemy = Instantiate(enemyTypes[enemyNumber], spawnPoints[spawnPoint].position, spawnPoints[spawnPoint].rotation, transform);
        enemies.Add (enemy);
        print(enemies.Count);
    }
    void KillEnemy()
    {
        //kills an enemy. Destroy the GameObject
        if(enemies.Count == 0)
            return;

        //Destroys the first enemy
        //Destroy(enemies[0]);
        //enemies.RemoveAt(0);

        //Destroys the last one
        Destroy(enemies[enemies.Count-1]);
        enemies.RemoveAt(enemies.Count-1);

        print(enemies.Count);
    }
}
