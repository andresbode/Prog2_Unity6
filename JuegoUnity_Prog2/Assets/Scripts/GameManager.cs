using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Configuración desde Editor")]
    [SerializeField] private PerfilJuego perfilActual;

    private int score;
    private int vidas;
    private int nivelActual = 1;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        // Usar las vidas del perfil
        vidas = perfilActual.vidasIniciales;
    }

    // Puntuación
    public void AddScore(int points)
    {
        score += points;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public int GetScore()
    {
        return score;
    }

    // Vidas
    public void PerderVida()
    {
        vidas--;
        if (vidas <= 0)
        {
            Debug.Log("GAME OVER - Reiniciar nivel");
        }
    }

    public int GetVidas()
    {
        return vidas;
    }

    // Niveles
    public void CompletarNivel()
    {
        nivelActual++;
        Debug.Log($"NIVEL COMPLETADO - Pasaste al nivel {nivelActual}");
    }

    public int GetNivelActual()
    {
        return nivelActual;
    }

    // Para que otros scripts obtengan configuraciones
    public float GetVelocidadJugador()
    {
        return perfilActual.velocidadJugador;
    }

    public float GetFuerzaSalto()
    {
        return perfilActual.fuerzaSalto;
    }
}