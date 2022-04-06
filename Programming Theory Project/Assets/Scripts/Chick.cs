using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : MonoBehaviour
{
    private float lowestChickSpeed = 1.5f;
    private float highestChickSpeed = 2.0f;

    

    // Update is called once per frame
    void Update()
    {
        MoveDownwards(lowestChickSpeed, highestChickSpeed);
        DestroyOutOfBounds();
    }

 



    public virtual void MoveDownwards(float low, float high)
    {

        transform.Translate(Vector3.back * Random.Range(low, high) * Time.deltaTime);


    }


    public void DestroyOutOfBounds()
    {
        if (transform.position.z < -8)
        {
            Destroy(gameObject);
        }
    }
}
