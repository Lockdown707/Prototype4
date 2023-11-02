using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallController : MonoBehaviour
{
    private Rigidbody cannonRb;
    public float ballForce;
    public float forwardForce;
    // Start is called before the first frame update
    void Start()
    {
       cannonRb = GetComponent<Rigidbody>();
        cannonRb.AddForce(Vector3.forward * ballForce, ForceMode.Impulse);
        cannonRb.AddForce(Vector3.up * forwardForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
