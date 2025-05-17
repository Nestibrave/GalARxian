using UnityEngine;
using UnityEngine.UI;

public class TextoFadeLoop : MonoBehaviour
{
    public Text textoUI;
    public float duracion = 1.5f; // Duración de cada fase (fade in o fade out)

    private float tiempo = 0f;
    private bool haciendoFadeIn = true;

    void Update()
    {
        if (textoUI == null) return;

        tiempo += Time.deltaTime;
        float alpha;

        if (haciendoFadeIn)
        {
            alpha = Mathf.Clamp01(tiempo / duracion);
        }
        else
        {
            alpha = Mathf.Clamp01(1 - (tiempo / duracion));
        }

        Color nuevoColor = textoUI.color;
        nuevoColor.a = alpha;
        textoUI.color = nuevoColor;

        if (tiempo >= duracion)
        {
            tiempo = 0f;
            haciendoFadeIn = !haciendoFadeIn;
        }
    }
}
