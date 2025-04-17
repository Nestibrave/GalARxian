using UnityEngine;

public class NaveScript : MonoBehaviour
{
    public float speed = 0f;

    [SerializeField] public Transform laserOrigin;
    [SerializeField] public GameObject laser;

    // Update is called once per frame
    void Update()
    {
        //Captura el input para mover de izquierda a derecha
        Move();

        //Captura el input para disparar
        Shoot();
    }

    void Move()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, transform.position.z, transform.position.z);
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire"))
        {
            Instantiate(laser, laserOrigin);
        }
    }
}
