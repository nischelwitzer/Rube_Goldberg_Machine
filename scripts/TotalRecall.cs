using UnityEngine;

public class TotalRecall : MonoBehaviour
{
    public int myWaitTime = 30; // time in seconds to set back
    private Vector3 pos;
    private Vector3 rot;
    private Vector3 scl;

    void Start()
    {
        pos = this.transform.position;
        rot = this.transform.eulerAngles;
        scl = this.transform.localScale;

        Debug.Log("PleaseGOBack Started");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("PleaseGOBack invoked by " + collision.gameObject.name);
        Invoke("SetMeBack", myWaitTime);
    }

    void SetMeBack() // resets all important GO parameters
    {
        this.transform.position = pos;
        this.transform.eulerAngles = rot;
        this.transform.localScale = scl;

        this.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        Debug.Log("PleaseGOBack SetMeBack");
    }
}
