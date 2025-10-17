using UnityEngine;
using UnityEngine.Events;

public class OnCollisionGeneric : MonoBehaviour
{
    [SerializeField] private UnityEvent myEvent = null;

    private void OnCollisionEnter(Collision collision)
    {
        myEvent.Invoke();
    }

}
