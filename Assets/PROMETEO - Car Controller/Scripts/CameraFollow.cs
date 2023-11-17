using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform carTransform;
    public float desiredDistance = 5.0f; // Distancia deseada entre el automóvil y la cámara
    public float followSpeedMultiplier = 1.0f; // Factor para ajustar la velocidad de seguimiento
    public float rotationSpeed = 2.0f; // Velocidad de rotación de la cámara
    public float xRotation = 13.682f; // Ángulo en el eje X
    public float heightOffset = 2.0f; // Altura de la cámara con respecto al automóvil

    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(0, heightOffset, -desiredDistance);
    }

    void FixedUpdate()
    {
        // Calcula la velocidad de seguimiento de la cámara basada en la velocidad del automóvil
        float followSpeed = carTransform.GetComponent<Rigidbody>().velocity.magnitude * followSpeedMultiplier;

        // Calcula la nueva posición deseada de la cámara manteniendo la distancia constante
        Vector3 targetPosition = carTransform.position + carTransform.TransformDirection(offset);

        // Mueve la cámara hacia la nueva posición con velocidad de seguimiento
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        // Calcula la rotación deseada de la cámara
        Quaternion targetRotation = Quaternion.Euler(xRotation, carTransform.eulerAngles.y, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
