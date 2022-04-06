using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// USE OF INHERITANCE
public class Chicken : Chick
{

    private float lowestChickenSpeed = 2.0f;
    private float highestChickenSpeed = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ABSTRACTION + AN INHERITED METHOD
        MoveDownwards(lowestChickenSpeed, highestChickenSpeed);

        // INHERITED METHOD
        DestroyOutOfBounds();

       
    }


    // USE OF POLYMORPHISM 
    //public override void MoveDownwards()
    //{
    //    transform.Translate(Vector3.forward * Random.Range(lowestChickenSpeed, highestChickenSpeed) * Time.deltaTime);
    //}

}
