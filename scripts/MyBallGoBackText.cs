using TMPro;
using UnityEngine;

// mit Textanzeige für RGM
// * Rundencounter
// * Rundenzeit

public class MyBallGoBackText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txtRound = null; // referenz auf das GameObject für die Rundenanzeige
    [SerializeField] private TextMeshProUGUI timeRound = null;
    
    private Rigidbody rb;
    private Vector3 startPosition;
    private int myRounds = 1;
    private float roundStartTime = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
        roundStartTime = Time.time;

        if (txtRound != null)
            txtRound.text = "Round: " + myRounds.ToString();
    }

    void Update()
    {
        if (timeRound != null)
            timeRound.text = (Time.time - roundStartTime).ToString("0.000") + " sec";

        if (this.transform.position.y < -30)
        {
            myRounds++;
            roundStartTime = Time.time;
            if (txtRound != null)
                txtRound.text = "Round: " + myRounds.ToString();

            transform.position = startPosition;
            // transform.rotation = Quaternion.identity;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
