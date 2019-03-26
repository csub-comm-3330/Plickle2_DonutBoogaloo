using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickleSplat : MonoBehaviour
{
    public Transform splat;

    private void OnTriggerEnter(Collider other)
    {
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, Vector3.one);
        Vector3 pos = transform.position;
        Destroy(this.gameObject);
        Instantiate(splat, pos, rot);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
