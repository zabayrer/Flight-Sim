using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject targetPrefab;
    private float spawnRangeX = 2487;
    private float spawnRangeZ = 2578;
    private float spawnRangeY = 300;
    private float startDelay = 5;
    private float spawnInterval = 15.0f;
    public int targetNum = 0;
    private float targetMax = 50;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnTarget", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void  spawnTarget()
    {
        //keep target number below the target max
        if (targetNum < targetMax)
        {
            //get a random position and rotation within world bounds
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), (Random.Range(0, spawnRangeY)), (Random.Range(-spawnRangeZ, spawnRangeZ)));
            var newRotation = Quaternion.Euler(90, (Random.Range(0, 360)), 0);
            //make a target at said random position and rotation
            Instantiate(targetPrefab, spawnPos, newRotation);
            //add one to the target number and tell the player what the target number is
            targetNum += 1;
            Debug.Log(targetNum);
        }
    }
}
