using UnityEngine;

public class LaserScript : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    [SerializeField] AudioSource laser;

    private void Start()
    {
        laser.Play();
    }


    void Update()
    {
        //Movimiento infinito hacia arriba
        transform.position = new Vector2(transform.position.x, transform.position.y + (moveSpeed * Time.deltaTime));

        //Destruye el láser cuando sale de la pantalla
        DestroyOffScreen();
        
    }

    void DestroyOffScreen()
    {
        if (transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }
}
