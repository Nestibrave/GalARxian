using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaPorIndice : MonoBehaviour
{
    [Tooltip("N�mero de la escena en Build Settings")]
    public int indiceDeEscena;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(indiceDeEscena);
        }
    }
}
