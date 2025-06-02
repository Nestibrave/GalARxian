using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    [Tooltip("�ndice de la escena a cargar (seg�n Build Settings)")]
    public int sceneIndex;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Clic izquierdo
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}

