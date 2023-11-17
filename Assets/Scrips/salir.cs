using UnityEngine;
using UnityEngine.UI;

public class CambiarCanvas : MonoBehaviour
{
    public Canvas menuCanvas;
    public Canvas notificacionesCanvas;

    private void Start()
    {
        // Aseg�rate de que el Canvas "menu" est� visible al inicio
        menuCanvas.enabled = true;
        notificacionesCanvas.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (notificacionesCanvas.enabled)
            {
                // Si el Canvas "notificaciones" est� abierto, ci�rralo y vuelve al Canvas "menu" al presionar Escape.
                CambiarCanvasNotificacionesMenu();
            }
            else
            {
                // Si est�s en el Canvas "menu" y presionas Escape, puedes realizar alguna acci�n adicional o simplemente salir del juego.
                // Por ejemplo, Application.Quit() para salir del juego.
                Application.Quit();
            }
        }
    }

    public void CambiarCanvasMenuNotificaciones()
    {
        // Cierra el Canvas "menu" y abre el Canvas "notificaciones" al hacer clic en el bot�n
        menuCanvas.enabled = false;
        notificacionesCanvas.enabled = true;
    }

    public void CambiarCanvasNotificacionesMenu()
    {
        // Cierra el Canvas "notificaciones" y abre el Canvas "menu" al hacer clic en el bot�n
        menuCanvas.enabled = true;
        notificacionesCanvas.enabled = false;
    }
}
