using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SonidoAlDisparar : MonoBehaviour
{
    public AudioClip sonidoDisparo;
    public float speed = 10f;

    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();

        if (sonidoDisparo != null)
        {
            audioSource.PlayOneShot(sonidoDisparo);
        }
    }
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
