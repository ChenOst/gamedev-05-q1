using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public float radius;
    public int speed;
    private Vector3 target;

    void Start()
    {
        // The object will rotate in circles around this point
        target = new Vector3(this.transform.position.x + radius, 0.0f, 0.0f);
    }

    void Update()
    {
        // The player using the RightArrow
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(target, Vector3.back, speed * Time.deltaTime);
        }

        // The player using the LeftArrow
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(target, Vector3.forward, speed * Time.deltaTime);
        }
    }
}
