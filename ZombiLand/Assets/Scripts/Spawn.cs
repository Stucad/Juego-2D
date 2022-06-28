using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemys;

    public float timeSpawn = 1;
    public float repiteSpawn = 3;

    public Transform puntosSpawnX;
    public Transform puntosSpawnX2;

    public Transform puntosSpawnY;
    public Transform puntosSpawnY2;

    public float difficultyTime = 0;
    




    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("EnemyDifficulty");

    }

    private void Update()
    {

        difficultyTime += Time.deltaTime;

        if (difficultyTime > 5 && difficultyTime < 10)
        {

            repiteSpawn = 2.45f;

        }

        if (difficultyTime > 10 && difficultyTime < 30)
        {

            repiteSpawn = 2;

        }

        if(difficultyTime > 20 && difficultyTime < 30)
        {

            repiteSpawn = 1;

        }

        if(difficultyTime > 30 && difficultyTime < 50)
        {

            repiteSpawn = 0.75f;

        }

        if(difficultyTime > 50)
        {

            repiteSpawn = 0.25f;

        }
    }

    IEnumerator EnemyDifficulty()
    {

        yield return new WaitForSeconds(repiteSpawn);
        SpawnEnemys();
        StartCoroutine("EnemyDifficulty");

    }

    public void SpawnEnemys()
    {

        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(puntosSpawnX.position.x, puntosSpawnX2.position.x), Random.Range(puntosSpawnY.position.y,puntosSpawnY2.position.y),0);

        GameObject enemy = Instantiate(enemys[Random.Range(0,enemys.Length)], spawnPosition, gameObject.transform.rotation);

    }
}
