using UnityEngine;

public class AudioLoop : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        InvokeRepeating("PlaySound", 5f, 5f);
    }

    private void PlaySound()
    {
        audioSource.Play();
    }
}