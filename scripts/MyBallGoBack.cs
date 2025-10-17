using UnityEngine;

public class MyBallGoBack : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    void Update()
    {
        if (this.transform.position.y < -30)
        {
            transform.position = startPosition;
            // transform.rotation = Quaternion.identity;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
