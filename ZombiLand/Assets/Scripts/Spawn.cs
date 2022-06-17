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
    




    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnEnemys", timeSpawn, repiteSpawn);


    }

    public void SpawnEnemys()
    {

        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(puntosSpawnX.position.x, puntosSpawnX2.position.x), Random.Range(puntosSpawnY.position.y,puntosSpawnY2.position.y),0);

        GameObject enemy = Instantiate(enemys[Random.Range(0,enemys.Length)], spawnPosition, gameObject.transform.rotation);

    }
}
