using UnityEngine;

[CreateAssetMenu(fileName = "PerfilJuego", menuName = "Scriptable Objects/PerfilJuego")]
public class PerfilJuego : ScriptableObject
{
    [Header("Configuraci�n de Dificultad")]
    public int vidasIniciales = 3;
    public int puntosPorMoneda = 100;
    public float multiplicadorPuntos = 1f;

    [Header("Configuraci�n de Jugador")]
    public float velocidadJugador = 5f;
    public float fuerzaSalto = 10f;
}