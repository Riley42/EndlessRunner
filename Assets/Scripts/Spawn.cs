using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float timeBetweenSpawns;
    public GameObject[] obstaclePods;
    private float timer;

    void Start()
    {
        timer = timeBetweenSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if (obstaclePods.Length <= 0)
        {
            return;
        }

        if (timer <= 0)
        {
            int rand = Random.Range(0, obstaclePods.Length);
            Instantiate(obstaclePods[rand], transform.position, transform.rotation);
            timer = Random.Range(timeBetweenSpawns - 1, timeBetweenSpawns + 1);
        }
        else
        {
            timer -= Time.deltaTime;
        }

    }
}
