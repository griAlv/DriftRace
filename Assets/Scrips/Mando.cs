using UnityEngine;

public class ControlDeCoche : MonoBehaviour
{
    public float velocidadMaxima = 10f;
    public float velocidadGiro = 3f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float inputAvance = Input.GetButton("b1") ? 1f : 0f; // Si se presiona el bot�n 1, avanza; de lo contrario, no avanza.
        float inputRetroceso = Input.GetButton("b3") ? -1f : 0f; // Si se presiona el bot�n 3, retrocede; de lo contrario, no retrocede.

        float inputHorizontal = Input.GetAxis("Horizontal"); // Obt�n el input del joystick horizontal

        Vector3 movimiento = new Vector3(0f, 0f, (inputAvance + inputRetroceso) * velocidadMaxima);
        rb.AddRelativeForce(movimiento);

        Quaternion rotacion = Quaternion.Euler(0f, inputHorizontal * velocidadGiro, 0f);
        rb.MoveRotation(rb.rotation * rotacion);
    }
}
