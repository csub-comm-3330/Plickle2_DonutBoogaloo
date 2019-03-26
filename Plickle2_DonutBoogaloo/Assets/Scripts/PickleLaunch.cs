using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickleLaunch : MonoBehaviour
{
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);
    }
}
