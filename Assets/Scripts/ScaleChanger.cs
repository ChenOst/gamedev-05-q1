using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    public float maxSize, minSize;
    public int speed;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        // Change the scale with 0.01f in all axis
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        // Change the object to its minimun size
        transform.localScale = new Vector3(minSize, minSize, minSize);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange * speed * Time.deltaTime;
        if (transform.localScale.y < minSize || transform.localScale.y > maxSize)
        {
            scaleChange = -scaleChange;
        }
    }
}
