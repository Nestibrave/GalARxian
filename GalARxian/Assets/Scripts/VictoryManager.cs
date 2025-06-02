using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryManager : MonoBehaviour
{
    public static VictoryManager Instance;

    public int victoria = 0;
    public int enemigosParaGanar = 18;
    public int indiceEscenaVictoria = 2;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        victoria = 0;
    }

    public void SumarVictoria()
    {
        victoria++;

        if (victoria >= enemigosParaGanar)
        {
            Debug.Log("¡Victoria! Cargando nueva escena...");
            SceneManager.LoadScene(indiceEscenaVictoria);
        }
    }
}


