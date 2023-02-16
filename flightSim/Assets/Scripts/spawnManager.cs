using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject targetPrefab;
    private float spawnRangeX = 10;
    private float spawnRangeZ = 10;
    private float spawnRangeY = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), (Random.Range(-spawnRangeY, spawnRangeY)), (Random.Range(-spawnRangeZ, spawnRangeZ)));
            Instantiate(targetPrefab, spawnPos, targetPrefab.transform.rotation);
        }
    }
}
