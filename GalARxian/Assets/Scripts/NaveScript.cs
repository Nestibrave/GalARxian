using UnityEngine;

public class NaveScript : MonoBehaviour
{
    public float speed = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, transform.position.z, transform.position.z);
    }
}
