using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public float distance, speed;
    public float xPosition, yPosition;
    bool switchPos = true;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (switchPos)
        {
            moveRight();
        }
        if (!switchPos)
        {
            moveLeft();
        }
        if (transform.position.x >= distance)
        {
            switchPos = false;
        }
        if (transform.position.x <= -distance)
        {
            switchPos = true;
        }

    }
    void moveRight()
    {
            transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    void moveLeft()
    {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
