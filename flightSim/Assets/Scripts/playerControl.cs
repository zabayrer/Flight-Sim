using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    //private variables
    private float speed = 20.0f;
    public float throttle = 0.0f;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //vehicle pitch
        transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontalInput);

        //vehicle yaw
        transform.Rotate(Vector3.right, Time.deltaTime * turnSpeed * forwardInput);
        //vehicle roll
        transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed * -horizontalInput);

        //vehicle throttle
        transform.Translate(Vector3.forward * Time.deltaTime * throttle);
        //change throttle
        if (Input.GetKey("="))
        {
            if (throttle < 100)
                throttle = throttle + 1;
        }

        if (Input.GetKey("-"))
        {
            throttle = throttle - 1;
        }
        //make sure plane can't go backwards
        if (throttle < 0)
        {
            throttle = 0;
        }
        //make sure plane can't go below ground, will change once full world is in place
        if (transform.position.y < -25)
        {
            //hard-coded values go brr
            transform.position = new Vector3(transform.position.x, -25, transform.position.z);
            Debug.Log("game over");
        }
        //when space is pressed, launch a projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}