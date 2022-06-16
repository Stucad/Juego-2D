using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemys;

    public float timeSpawn = 1;
    public float repiteSpawn = 3;

    public Transform puntosSpawn;
    public Transform puntosSpawn1;
    




    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnEnemys", timeSpawn, repiteSpawn);


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void SpawnEnemys()
    {

        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(puntosSpawn.position.x, puntosSpawn1.position.x), 0);

    }
}
