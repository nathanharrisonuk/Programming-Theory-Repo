using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Projectile : MonoBehaviour
{





    // ENCAPSULATED the variable as private after finding the right speed
    private float projectileSpeed = 40.0f;
    private GameManager gameManagerScript;


    private void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
        


        






    public void Update()
    {
        MoveForward();
        DestroyOutOfBounds();
    }


    public void MoveForward()
    {
        transform.Translate(projectileSpeed * Time.deltaTime * Vector3.forward);
    }


    private void DestroyOutOfBounds()
    {
        if (transform.position.z > 10)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Chick"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            gameManagerScript.UpdateScore();
           
        }


    }




    
}


