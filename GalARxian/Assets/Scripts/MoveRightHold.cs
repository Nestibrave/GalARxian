using UnityEngine;
using UnityEngine.EventSystems;

public class MoveRightHold : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject nave;             // Asigna tu nave desde el Inspector
    public float moveSpeed = 5f;        // Velocidad de movimiento

    private bool isHeld = false;

    void Update()
    {
        if (isHeld && nave != null)
        {
            nave.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isHeld = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHeld = false;
    }
}
