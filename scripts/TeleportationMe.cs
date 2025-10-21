using UnityEngine;
using UnityEngine.UIElements;

public class TeleportationMe : MonoBehaviour
{
    [SerializeField] private GameObject goalTo = null;

    private void OnTriggerEnter(Collider collision)
    {
        if (goalTo != null)
            collision.transform.position = 
                goalTo.transform.position + Vector3.up * 10;
    }
}

