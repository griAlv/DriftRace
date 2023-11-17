using UnityEngine;
using UnityEngine.UI;

public class CambiarCanvas : MonoBehaviour
{
    public Canvas menuCanvas;
    public Canvas notificacionesCanvas;

    private void Start()
    {
        // Asegúrate de que el Canvas "menu" esté visible al inicio
        menuCanvas.enabled = true;
        notificacionesCanvas.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (notificacionesCanvas.enabled)
            {
                // Si el Canvas "notificaciones" está abierto, ciérralo y vuelve al Canvas "menu" al presionar Escape.
                CambiarCanvasNotificacionesMenu();
            }
            else
            {
                // Si estás en el Canvas "menu" y presionas Escape, puedes realizar alguna acción adicional o simplemente salir del juego.
                // Por ejemplo, Application.Quit() para salir del juego.
                Application.Quit();
            }
        }
    }

    public void CambiarCanvasMenuNotificaciones()
    {
        // Cierra el Canvas "menu" y abre el Canvas "notificaciones" al hacer clic en el botón
        menuCanvas.enabled = false;
        notificacionesCanvas.enabled = true;
    }

    public void CambiarCanvasNotificacionesMenu()
    {
        // Cierra el Canvas "notificaciones" y abre el Canvas "menu" al hacer clic en el botón
        menuCanvas.enabled = true;
        notificacionesCanvas.enabled = false;
    }
}
