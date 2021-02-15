using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TODO Ball can fly in air
//TODO Scenetransitions, reset button, drop new ball etc.

public class SwipeControl : MonoBehaviour
{
    Vector2 startPos, endPos, direction;
    public float touchTimeStart, touchTimeFinish, timeInterval;

    public float swipeForceXandY = 1f;
    public float swipeForceInZ = 50f;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchTimeFinish = Time.time;

            timeInterval = touchTimeFinish - touchTimeStart;

            endPos = Input.GetTouch(0).position;

            direction = startPos - endPos;

            rb.isKinematic = false;
            rb.AddForce(- direction.x * swipeForceXandY, - direction.y * swipeForceXandY, swipeForceInZ / timeInterval);
        }
        
        
    }
}
