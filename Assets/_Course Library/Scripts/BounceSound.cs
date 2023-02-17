using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip bounceSound;
    [SerializeField] GameObject[] hands;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        bool collisionWithHand = false;
        foreach (GameObject hand in hands)
        {
            if (collision.gameObject == hand)
            {
                collisionWithHand = true;
                break;
            }
        }

        if (!collisionWithHand)
        {
            audioSource.PlayOneShot(bounceSound);
            float volume = rb.velocity.magnitude / 10;
            audioSource.volume = Mathf.Clamp(volume, 0.1f, 1);
        }
    }
}
