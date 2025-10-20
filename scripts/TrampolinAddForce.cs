
using UnityEngine;

public class TrampolinAddForce : MonoBehaviour
{
    public int myAddForceValue = 300;

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody myOtherObject = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 myForce = new Vector3(0, myAddForceValue, 0);
        myOtherObject.AddForce(myForce * myOtherObject.mass);

        Debug.Log("OnCollisionEnter: " + collision.gameObject.name);
    }
}

