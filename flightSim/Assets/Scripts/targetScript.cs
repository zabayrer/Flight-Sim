using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetScript : MonoBehaviour
{
    private spawnManager spawnManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        spawnManagerScript = GameObject.Find("spawnManager").GetComponent<spawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            spawnManagerScript.targetNum -= 1;
        }
    }
    //destroy the target whenever it hits or gets hit by something
    //also prevents it from spawning inside the world maybe
    private void OnTriggerEnter(Collider other)
    {
         //tell the spawn manager to subtract 1 from the total number of targets
        spawnManagerScript.targetNum -= 1;

        Destroy(gameObject);
       
    }
}
