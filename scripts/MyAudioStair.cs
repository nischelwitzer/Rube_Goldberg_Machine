using UnityEngine;

public class MyAudioStair : MonoBehaviour
{
    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = this.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (audioSrc != null && !audioSrc.isPlaying) audioSrc.Play();
        Debug.Log("Trigger detected with " + other.gameObject.name);    
    }

}

