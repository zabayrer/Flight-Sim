using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    //private variables
    private Rigidbody playerRb;
    private float speed = 20.0f;
    public float throttle = 0.0f;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;
    public bool gameOver = false;
    public GameObject projectilePrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //make sure player can't do anything after they die
        if (gameOver == false) 
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

            //when space is pressed, launch a projectile
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(projectilePrefab, transform.position, transform.rotation);
            }
        }

        //vehicle throttle
        transform.Translate(Vector3.forward * Time.deltaTime * throttle);
        //change throttle
        if (Input.GetKey("=") && !gameOver)
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
            
            gameOver = true;
        }
       
        //when player dies
        if (gameOver == true)
        {
            Debug.Log("game over");
            throttle = 0;
        }
    }
    //die if the player collides with a world object
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WorldObject"))
            {
                gameOver = true;                
            }
    }
}