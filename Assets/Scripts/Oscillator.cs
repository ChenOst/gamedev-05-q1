using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    public float xDistance, yDistance;
    private float slowDownDistance;
    private Vector3 target, target1, target2;
    private float speed;
    // Use this for initialization
    void Start()
    {
        target1 = new Vector3(transform.position.x + xDistance, transform.position.y + yDistance, 0);
        target2 = new Vector3(transform.position.x - xDistance, transform.position.y - yDistance, 0);
        target = target1;
        speed = maxSpeed;
        if (xDistance <= yDistance)
        {
            slowDownDistance = (xDistance + 1) / 2;
        }
        else
        {
            slowDownDistance = (yDistance + 1) / 2;
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        float distance = Vector3.Distance(transform.position, target);

        if (distance < slowDownDistance)
        {
            float percentageOfMax = Vector3.Distance(transform.position, target) / slowDownDistance;

            speed = Mathf.MoveTowards(minSpeed, maxSpeed, percentageOfMax * maxSpeed);
        }

        if (transform.position == target1)
        {
            target = target2;
            speed = maxSpeed;
        }
        if (transform.position == target2)
        {
            target = target1;
            speed = maxSpeed;
        }
    }
}
