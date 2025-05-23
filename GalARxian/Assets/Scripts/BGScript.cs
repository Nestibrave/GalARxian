using UnityEngine;

public class BGScript : MonoBehaviour
{
    [SerializeField] private Vector2 moveSpeed;

    private Vector2 offset;

    private Material material;


    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = moveSpeed * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
