using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private GameManager gameManagerScript;


    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Chick"))
        {
            gameManagerScript.GameOver();
        }
    }
}
