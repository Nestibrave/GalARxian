using UnityEngine;

public class ProyectilDestruyeEnemigos : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string[] nombresValidos = {
            "Enemies_0", "Enemies_1", "Enemies_2",
            "Enemies_3", "Enemies_4", "Enemies_5",
            "Enemies_6", "Enemies_7", "Enemies_8"
        };

        foreach (string nombre in nombresValidos)
        {
            if (collision.gameObject.name == nombre)
            {
                Destroy(collision.gameObject); // Destruye al enemigo
                Destroy(gameObject);           // Destruye al proyectil
                VictoryManager.Instance.SumarVictoria();
                break;
            }
        }
    }
}
