using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour



{
    public Transform[] enemySpawner;
    public GameObject enemy ;
    // Start is called before the first frame update
    public int randomNumber = 0;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f ,2f);

    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range( 0  , enemySpawner.Length );
    }


    private void SpawnEnemy(){

        Instantiate(enemy, enemySpawner[randomNumber].position , enemySpawner[randomNumber].rotation);
    }
}
