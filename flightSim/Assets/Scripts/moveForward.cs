using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed = 15.0f;
    public float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
/* //haha none of this works aaaahhh
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WorldObject"))
        {
            Destroy(gameObject);
        }else if (collision.gameObject.CompareTag("target"))
        {
            Destroy(gameObject); //target and projectile
            score += 1;
            Debug.Log(score);
            //targetNum -= 1
        }
    }*/
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

    }
}
