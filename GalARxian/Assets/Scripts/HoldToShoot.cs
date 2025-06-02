using UnityEngine;
using UnityEngine.EventSystems;

public class HoldToShoot : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject nave;           // Asigna tu nave desde el Inspector
    public GameObject laserPrefab;    // Prefab del proyectil (Laser)
    public float shootInterval = 0.25f;

    private bool isHeld = false;
    private float shootTimer = 0f;

    void Update()
    {
        if (isHeld && nave != null && laserPrefab != null)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0f)
            {
                Disparar();
                shootTimer = shootInterval;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isHeld = true;
        shootTimer = 0f; // Dispara inmediatamente
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHeld = false;
    }

    void Disparar()
    {
        Instantiate(laserPrefab, nave.transform.position, Quaternion.identity);
    }
}

