using UnityEngine;

public class MovimientoGalagaConReaparicion : MonoBehaviour
{
    public float velocidadHorizontal = 2f;
    public float distanciaMaxima = 3f;
    public float bajada = 0.5f;
    public float limiteInferiorY = -6f;  // Límite inferior de la pantalla
    public float reposicionY = 6f;       // Altura en Y para reaparecer

    private Vector3 posicionInicial;
    private bool moviendoDerecha = true;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        float movimiento = velocidadHorizontal * Time.deltaTime;

        if (moviendoDerecha)
        {
            transform.Translate(Vector2.right * movimiento);
            if (transform.position.x >= posicionInicial.x + distanciaMaxima)
            {
                moviendoDerecha = false;
                transform.position += Vector3.down * bajada;
            }
        }
        else
        {
            transform.Translate(Vector2.left * movimiento);
            if (transform.position.x <= posicionInicial.x - distanciaMaxima)
            {
                moviendoDerecha = true;
                transform.position += Vector3.down * bajada;
            }
        }

        // Reaparecer si cae fuera del límite inferior
        if (transform.position.y <= limiteInferiorY)
        {
            Vector3 nuevaPos = transform.position;
            nuevaPos.y = reposicionY;
            transform.position = nuevaPos;
        }
    }
}

