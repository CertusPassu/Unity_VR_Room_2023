using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicOnRecorder : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] GameObject recorderHandle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == recorderHandle)
        {
            music.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == recorderHandle)
        {
            music.Stop();
        }
    }
}
