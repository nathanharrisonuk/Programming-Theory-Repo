using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject projectile;
    private GameManager gameManagerScript;

    private float speed = 15.0f;

    private float horizontalInput;
   // private float verticalInput;

    private float xBounds = 8.5f;

    // private float turnSpeed = 50.0f;


    private void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }


    // Update is called once per frame
    void Update()
    {
        
        // a form of abstraction by calling the method from update
        Move();
        Fire();
    }








    // creating a separate method is a form of abstraction - keeps the code tidier

    protected void Move()
    {
        
        // INHERITED A PROTECTED BOOL VARIABLE
        if (gameManagerScript.isGameActive == true)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

            if (transform.position.x <= -xBounds)
            {
                transform.position = new Vector3(-xBounds, transform.position.y, transform.position.z);
            }
            else if (transform.position.x >= xBounds)
            {
                transform.position = new Vector3(xBounds, transform.position.y, transform.position.z);
            }
        }
    }



    public void Fire()
    {
        if (gameManagerScript.isGameActive == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(projectile, transform.position, transform.rotation);
            }
        }
    }


    /*

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
       
    }

   
    */
}
