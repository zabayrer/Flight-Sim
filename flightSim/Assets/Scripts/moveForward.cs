using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed = 15.0f;
    public float score = 0;
    public float zBound = 2578;
    public float xBound = 2487;
    public float yBound = 350;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //go forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //destroy projectile when out of game boundary
        if (transform.position.z > zBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -zBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > xBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > yBound)
        {
            Destroy(gameObject);
        }
    }
 
    //destroy the projectile if it collides with either a world object or a target.
    //side note: don't known why OnCollisonEnter wasn't working, David helped me out.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("WorldObject") || collision.gameObject.CompareTag("target"))
        {
            Destroy(gameObject);
        }
    }


}
