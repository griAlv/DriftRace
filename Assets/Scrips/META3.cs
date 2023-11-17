using UnityEngine;
using UnityEngine.SceneManagement;

public class Contr0lColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            // Cargar la escena de victoria cuando el jugador colisiona.
            SceneManager.LoadScene("VICTORIA3");
        }
        else if (other.gameObject.CompareTag("Rival"))
        {
            // Cargar la escena de derrota cuando el rival colisiona.
            SceneManager.LoadScene("DERROTA3");
        }
    }
}
