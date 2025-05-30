using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetector : MonoBehaviour
{
    public float yLimit = -5f; // L�mite de ca�da
    public string sceneToLoad = "GameOver"; // Nombre de la escena

    void Update()
    {
        if (transform.position.y <= yLimit)
        {
            Debug.Log("�Objeto cay� por debajo del l�mite! Cargando escena GameOver...");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
