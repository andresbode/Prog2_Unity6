using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int score;
    private int vidas = 3;
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
}