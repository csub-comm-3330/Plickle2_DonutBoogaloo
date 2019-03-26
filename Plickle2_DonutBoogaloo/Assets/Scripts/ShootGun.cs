using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    private GameObject nothing;
    public GameObject boulder;
    Vector3 sphereVector;
    public GameObject pickle;

    public float delayTime = 3;
    private float counter = 0;



    private void Start()
    {
        sphereVector = new Vector3(0f, 14f, 24f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int layerMask = 1 << 10;
        layerMask = ~layerMask;
        counter += Time.deltaTime;

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 pickleVector;
            pickleVector = transform.TransformPoint(Vector3.right * 10);
            Instantiate(pickle, pickleVector, transform.rotation);

            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, layerMask))
            {
                Debug.DrawLine(ray.origin, hit.point);
                Debug.Log(hit.transform.name);
            }
            else
            {
                nothing = null;
                Debug.Log("Nothing! You Get Absolutely Nothing!");
            }

        }

        if (Input.GetButtonDown("Fire2") && counter > delayTime)
        {
            Instantiate(boulder, sphereVector, transform.rotation);
            counter = 0;
        }
    }
}
