using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    [Tooltip("Índice de la escena a cargar (según Build Settings)")]
    public int sceneIndex;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Clic izquierdo
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}

