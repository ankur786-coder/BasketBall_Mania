using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Vector2 startposition, endposition, direction;
    float startTime, endTime, totalTime;
    public float force = 0.2f;



    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startposition = Input.GetTouch(0).position;
            startTime = Time.time;
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endposition = Input.GetTouch(0).position;
            endTime = Time.time;
            direction = endposition - startposition;
            totalTime = endTime - startTime;
            this.GetComponent<Rigidbody2D>().AddForce(direction / totalTime * force);
        }
        
    }
}
