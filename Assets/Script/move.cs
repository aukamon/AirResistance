using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    public float enginePowerThrust, liftBooster, drag, angularDrag;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * enginePowerThrust);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * enginePowerThrust*-1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * enginePowerThrust*-1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * enginePowerThrust);
        }
    }
}
