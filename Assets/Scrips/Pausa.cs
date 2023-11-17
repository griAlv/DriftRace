using UnityEngine;
using UnityEngine.UI;

public class ControlEscena : MonoBehaviour
{
    public Canvas menuPausaCanvas; // Arrastra el Canvas del men� de pausa desde el Inspector.

    private void Start()
    {
        menuPausaCanvas.enabled = false; // Aseg�rate de que el Canvas est� desactivado al inicio.
    }

    public void MostrarMenuPausa()
    {
        Time.timeScale = 0f; // Det�n el tiempo para pausar el juego.
        menuPausaCanvas.enabled = true; // Activa el Canvas del men� de pausa.
    }

    public void ReanudarJuego()
    {
        Time.timeScale = 1f; // Reanuda el tiempo para continuar el juego.
        menuPausaCanvas.enabled = false; // Desactiva el Canvas del men� de pausa.
    }
}
