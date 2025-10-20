using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class GenericEvent4ColliderTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent myColliderEventEnter = null;
    [SerializeField] private UnityEvent myColliderEventExit = null;

    [SerializeField] private UnityEvent myTriggerEventEnter = null;
    [SerializeField] private UnityEvent myTriggerEventExit = null;

    [SerializeField] private GameObject onlyThisGO;

    void Start()
    {
        Debug.Log("GenericEvent4ColliderTrigger initialized on " + gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (onlyThisGO != null)
        {
            if (onlyThisGO.gameObject.name == other.gameObject.name)
                myTriggerEventEnter.Invoke();
        }
        else
            myTriggerEventEnter.Invoke();

        Debug.Log("Generic Trigger detected with " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        if (onlyThisGO != null)
        {
            if (onlyThisGO.gameObject.name == other.gameObject.name)
                myTriggerEventExit.Invoke();
        }
        else
            myTriggerEventExit.Invoke();

        Debug.Log("Generic Trigger detected with " + other.gameObject.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        myColliderEventEnter.Invoke();
        Debug.Log("Generic Collision detected with " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        myColliderEventExit.Invoke();
        Debug.Log("Generic Collision detected with " + collision.gameObject.name);
    }
}


