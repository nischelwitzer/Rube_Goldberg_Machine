using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PleaseGOBackInvoke : MonoBehaviour
{
    public int myWaitTime = 5;
    private Vector3 myPos;
    private Vector3 myRot;

    void Start()
    {
        myPos = this.transform.position;
        myRot = this.transform.rotation.eulerAngles;

        Debug.Log("PleaseGOBack Started");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "SphereBeachBall")
        {
            Debug.Log("PleaseGOBack invoked");
            Invoke("SetMeBack", myWaitTime);
        }
    }

    void SetMeBack()
    {
        this.transform.position = myPos;
        this.transform.eulerAngles = myRot;

        this.GetComponent<Rigidbody>().linearVelocity = Vector3.zero; // .velocity
        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        Debug.Log("PleaseGOBack SetMeBack");
    }
}
