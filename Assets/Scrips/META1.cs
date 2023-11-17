using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            // Cargar la escena de victoria cuando el jugador colisiona.
            SceneManager.LoadScene("VICTORIA1");
        }
        else if (other.gameObject.CompareTag("Rival"))
        {
            // Cargar la escena de derrota cuando el rival colisiona.
            SceneManager.LoadScene("DERROTA1");
        }
    }
}
