using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            // Cargar la escena de victoria cuando el jugador colisiona.
            SceneManager.LoadScene("VICTORIA2");
        }
        else if (other.gameObject.CompareTag("Rival"))
        {
            // Cargar la escena de derrota cuando el rival colisiona.
            SceneManager.LoadScene("DERROTA2");
        }
    }
}
