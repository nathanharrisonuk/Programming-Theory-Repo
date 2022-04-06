using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// USE OF INHERITANCE
public class Rooster : Chick
{

    private float lowestRoosterSpeed = 2.0f;
    private float highestRoosterSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ABSTRACTION + AN INHERITED METHOD
        MoveDownwards(lowestRoosterSpeed, highestRoosterSpeed);
        DestroyOutOfBounds();
    }



    


}


        
  


