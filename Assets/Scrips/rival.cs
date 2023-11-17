using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CompetitorAI : MonoBehaviour
{
    public Transform[] waypoints; // Array de waypoints que definen la ruta
    private int currentWaypointIndex = 0;
    private NavMeshAgent navAgent;

    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        SetNextWaypoint();
    }

    void Update()
    {
        // Comprueba si el competidor ha llegado al waypoint actual
        if (!navAgent.pathPending && navAgent.remainingDistance < 0.5f)
        {
            SetNextWaypoint();
        }
    }

    void SetNextWaypoint()
    {
        if (currentWaypointIndex < waypoints.Length)
        {
            // Establece el siguiente waypoint como destino
            navAgent.SetDestination(waypoints[currentWaypointIndex].position);
            currentWaypointIndex++;
        }
        else
        {
            // El competidor ha llegado al final de la ruta, puedes reiniciar la ruta o realizar otra acción.
        }
    }
}
