using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTilt : MonoBehaviour
{
    // The speed that the platform rotates at
    public float speed = 50f;

    float maxRightRotation = 35;
    float maxLeftRotation = 65;

    // Update is called once per frame
    void Update()
    {
        //whilst holding right arrow, platform tilts right
        if(Input.GetKey(KeyCode.RightArrow) && transform.eulerAngles.z >= maxRightRotation && transform.eulerAngles.z <= maxLeftRotation)
        {
            transform.Rotate(0.0f, 0.0f, -speed  * Time.deltaTime);
            bufferCheck();
        }
        //whilst holding left arrow, platform tilts left
        if (Input.GetKey(KeyCode.LeftArrow) && transform.eulerAngles.z >= maxRightRotation && transform.eulerAngles.z <= maxLeftRotation)
        {
            transform.Rotate(0.0f, 0.0f, speed * Time.deltaTime);
            bufferCheck();
        }
    }


    //if angle goes over threshold (which it will) then set rotation back within threshold to give layer control again
    void bufferCheck()
    {
        if(transform.eulerAngles.z <= maxRightRotation)
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
        if (transform.eulerAngles.z >= maxLeftRotation)
        {
            transform.Rotate(0, 0, -speed * Time.deltaTime);
        }
    }
}
