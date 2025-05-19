using UnityEngine;

public class LanzarProyectil : MonoBehaviour
{
    public GameObject proyectilPrefab;
    public Transform puntoDeDisparo;
    public float velocidadProyectil = 10f;

    private GameObject proyectilActivo;
    [SerializeField] AudioSource laser;

    private void Start()
    {
        laser.Play();
    }
    void Update()
    {
        // Solo lanza si se presiona Espacio y no hay proyectil activo
        if (Input.GetKeyDown(KeyCode.Space) && proyectilActivo == null)
        {
            Lanzar();
        }

        // Verifica si el proyectil sali� de pantalla
        if (proyectilActivo != null && proyectilActivo.transform.position.y > Camera.main.orthographicSize + 4f)
        {
            Destroy(proyectilActivo);
            proyectilActivo = null;
        }
    }

    void Lanzar()
    {
        proyectilActivo = Instantiate(proyectilPrefab, puntoDeDisparo.position, Quaternion.identity);
        Rigidbody2D rb = proyectilActivo.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = Vector2.up * velocidadProyectil;
        }
    }
}

