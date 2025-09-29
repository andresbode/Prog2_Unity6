using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public void RecibirDano()
    {
        // Solo usamos GameManager para las vidas
        GameManager.Instance.PerderVida();
        Debug.Log($"Vidas restantes: {GameManager.Instance.GetVidas()}");
    }

    private bool EstasVivo()
    {
        // Verificamos contra las vidas del GameManager
        return GameManager.Instance.GetVidas() > 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Meta")) { return; }

        GameManager.Instance.CompletarNivel();
        Debug.Log("GANASTE - Nivel: " + GameManager.Instance.GetNivelActual());
    }
}