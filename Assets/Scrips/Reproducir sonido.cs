using UnityEngine;
using UnityEngine.UI;

public class ReproducirSonido : MonoBehaviour
{
    public AudioSource source; // Referencia al componente AudioSource
    public AudioClip clip; // El AudioClip que deseas reproducir

    private void Start()
    {
        // Obtener el componente AudioSource adjunto al mismo GameObject
        source = GetComponent<AudioSource>();

        // Agregar un listener al botón para que llame a la función PlaySound cuando se presione
        Button button = GetComponent<Button>();
        button.onClick.AddListener(PlaySound);
    }

    // Función para reproducir el sonido
    void PlaySound()
    {
        // Asegurarse de que el AudioSource y el AudioClip estén configurados
        if (source != null && clip != null)
        {
            source.PlayOneShot(clip);
        }
        else
        {
            Debug.LogError("AudioSource o AudioClip no configurados.");
        }
    }
}
