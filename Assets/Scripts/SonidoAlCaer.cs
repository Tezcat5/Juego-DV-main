using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoAlCaer : MonoBehaviour

{
    [SerializeField] private AudioClip sonidoCaer;
    [SerializeField] private AudioClip sonidoMuerte;

    private Rigidbody2D rb;
    private bool haCaido = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Si el objeto ha caído y aún no se ha reproducido el sonido de caída
        if (!haCaido && rb.velocity.y < -1f)
        {
            haCaido = true;
            ReproducirSonido(sonidoCaer);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el objeto ha caído y ha colisionado con el suelo
        if (haCaido && collision.gameObject.CompareTag("Suelo"))
        {
            ReproducirSonido(sonidoMuerte);
        }
    }

    private void ReproducirSonido(AudioClip clip)
    {
        if (clip != null)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}