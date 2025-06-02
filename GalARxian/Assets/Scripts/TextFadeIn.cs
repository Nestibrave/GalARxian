using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextFadeIn : MonoBehaviour
{
    public Text uiText;            // Referencia al texto UI
    public float duration = 2f;    // Duración del fade-in

    void Start()
    {
        if (uiText != null)
        {
            // Establecer alfa en 0 al inicio
            Color invisibleColor = uiText.color;
            invisibleColor.a = 0f;
            uiText.color = invisibleColor;

            StartCoroutine(FadeIn());
        }
    }

    IEnumerator FadeIn()
    {
        float timer = 0f;
        Color startColor = uiText.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1f);

        while (timer < duration)
        {
            uiText.color = Color.Lerp(startColor, endColor, timer / duration);
            timer += Time.deltaTime;
            yield return null;
        }

        // Asegurar que quede completamente visible al final
        uiText.color = endColor;
    }
}


