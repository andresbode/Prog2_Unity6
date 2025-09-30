using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoIA : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] float velocidad = 5f;
    [SerializeField] float rangoDeteccion = 5f; // Nueva variable

    private Transform jugador;
    private Rigidbody2D miRigidbody2D;
    private Vector2 direccion;

    private void Awake()
    {
        miRigidbody2D = GetComponent<Rigidbody2D>();
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

   private void FixedUpdate()
{
    float distancia = Vector2.Distance(transform.position, jugador.position);
    
    if (distancia <= rangoDeteccion)
    {
        direccion = (jugador.position - transform.position).normalized;
        
        // Solo movimiento horizontal
        miRigidbody2D.linearVelocity = new Vector2(direccion.x * velocidad, miRigidbody2D.linearVelocity.y);
    }
    else
    {
        // Detener movimiento horizontal solo
        miRigidbody2D.linearVelocity = new Vector2(0f, miRigidbody2D.linearVelocity.y);
    }
}
}