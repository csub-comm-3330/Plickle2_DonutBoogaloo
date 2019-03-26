using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDonut : MonoBehaviour
{
    public float secPerCycle = 1;
    public float distance = 10;
    Vector3 initialPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var x = distance * Mathf.Cos(Time.time / secPerCycle * 2 * Mathf.PI);
        transform.position = initialPosition + Vector3.left * x;
    }

}
