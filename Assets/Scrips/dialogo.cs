using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    public TextMeshProUGUI dialogoText;
    public string[] lines;
    public float textSpeed = 0.4f;
    public float lineChangeInterval = 5.0f; // Intervalo de cambio de l�nea.

    private int index;
    private bool isTyping;
    private float timer; // Contador de tiempo para cambiar de l�nea.

    void Start()
    {
        dialogoText.text = string.Empty;
        index = 0;
        isTyping = false;
        timer = lineChangeInterval; // Iniciar el temporizador.
        StartCoroutine(WriteLine());
    }

    void Update()
    {
        // Actualizar el temporizador.
        if (index < lines.Length && !isTyping)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = lineChangeInterval;
                CompleteLine();
            }
        }
    }

    IEnumerator WriteLine()
    {
        isTyping = true;
        foreach (char letter in lines[index].ToCharArray())
        {
            dialogoText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
        isTyping = false;
    }

    public void CompleteLine()
    {
        if (isTyping)
        {
            // Si el di�logo se est� escribiendo, muestra el texto completo de inmediato.
            StopAllCoroutines();
            dialogoText.text = lines[index];
            isTyping = false;
        }
        else if (index < lines.Length - 1)
        {
            // Si el di�logo se ha completado y hay m�s l�neas, pasa a la siguiente l�nea.
            index++;
            dialogoText.text = string.Empty;
            StartCoroutine(WriteLine());
        }
        else
        {
            // Si no hay m�s l�neas, desactiva el di�logo.
            gameObject.SetActive(false);
        }
    }
}
