
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerGeneric : MonoBehaviour
{

    [SerializeField] private UnityEvent myEvent = null;

    private void OnTriggerEnter(Collider other)
    {
        myEvent.Invoke();
    }
}


