using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float timeBetweenSpawns;
    [SerializeField] GameObject[] spawnTemplates;
    float spawnTimer;

    private void Start()
    {
        spawnTimer = timeBetweenSpawns;
    }

    private void Update()
    {
        if (spawnTemplates.Length == 0) return;

        if (spawnTimer <= 0)
        {
            int rand = Random.Range(0, spawnTemplates.Length);
            Instantiate(spawnTemplates[rand], transform.position, Quaternion.identity);
            spawnTimer = timeBetweenSpawns;
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
    }
}
