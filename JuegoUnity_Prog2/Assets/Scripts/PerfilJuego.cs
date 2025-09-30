using UnityEngine;

[CreateAssetMenu(fileName = "PerfilJuego", menuName = "Scriptable Objects/PerfilJuego")]
public class PerfilJuego : ScriptableObject
{
    [Header("Configuración de Dificultad")]
    public int vidasIniciales = 3;
    public int puntosPorMoneda = 100;
    public float multiplicadorPuntos = 1f;

    [Header("Configuración de Jugador")]
    public float velocidadJugador = 5f;
    public float fuerzaSalto = 10f;
}