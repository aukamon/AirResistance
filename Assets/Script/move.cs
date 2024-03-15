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
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginePowerThrust);
        }

        Vector3 lift = Vector3.Project(rb.velocity, transform.forward);
        rb.AddForce(transform.up * lift.magnitude * liftBooster);

        rb.drag = rb.velocity.magnitude * angularDrag;

        rb.AddTorque(Input.GetAxis("Horizontal") * transform.forward * -1);

        rb.AddTorque(Input.GetAxis("Vertical") * transform.right);
    }
}
