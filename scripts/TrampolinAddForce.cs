
using UnityEngine;

public class TrampolinAddForce : MonoBehaviour
{
    public int myAddForceValue = 300;

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody myOtherObjectRB = collision.gameObject.GetComponent<Rigidbody>();

        // Vector3 myForce = new Vector3(0, myAddForceValue, 0);
        // oder 
        Vector3 myForce = Vector3.up * myAddForceValue;

        if (myOtherObjectRB != null)
            myOtherObjectRB.AddForce(myForce * myOtherObjectRB.mass);

        Debug.Log("OnCollisionEnter: " + collision.gameObject.name);
    }
}

