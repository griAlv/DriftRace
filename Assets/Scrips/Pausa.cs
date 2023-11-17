using UnityEngine;
using UnityEngine.UI;

public class ControlEscena : MonoBehaviour
{
    public Canvas menuPausaCanvas; // Arrastra el Canvas del menú de pausa desde el Inspector.

    private void Start()
    {
        menuPausaCanvas.enabled = false; // Asegúrate de que el Canvas esté desactivado al inicio.
    }

    public void MostrarMenuPausa()
    {
        Time.timeScale = 0f; // Detén el tiempo para pausar el juego.
        menuPausaCanvas.enabled = true; // Activa el Canvas del menú de pausa.
    }

    public void ReanudarJuego()
    {
        Time.timeScale = 1f; // Reanuda el tiempo para continuar el juego.
        menuPausaCanvas.enabled = false; // Desactiva el Canvas del menú de pausa.
    }
}
