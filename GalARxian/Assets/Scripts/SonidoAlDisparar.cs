using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SonidoAlDisparar : MonoBehaviour
{
    public AudioClip sonidoDisparo;

    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();

        if (sonidoDisparo != null)
        {
            audioSource.PlayOneShot(sonidoDisparo);
        }
    }
}
