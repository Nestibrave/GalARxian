using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetector : MonoBehaviour
{
    public float yLimit = -5f; // Límite de caída
    public string sceneToLoad = "GameOver"; // Nombre de la escena

    void Update()
    {
        if (transform.position.y <= yLimit)
        {
            Debug.Log("¡Objeto cayó por debajo del límite! Cargando escena GameOver...");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
