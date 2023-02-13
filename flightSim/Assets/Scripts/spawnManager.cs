using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;

    private float spawnDelay = 5;
    private float spawnRate = 10;
    private float randomX;
    private float randomY;
    private float randomZ;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", spawnDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawnObstacle()
    {
        //this is an awful workaround and i want to kill it
        randomX = Random.Range(-10, 10);
        randomY = Random.Range(-10, 10);
        randomZ = Random.Range(-10, 10);
        private float spawnPos = new Vector3(randomX, randomY, randomZ);
    Instantiate(obstaclePrefab, spawnPos, spawnRotation);
}
    


