using UnityEngine;
using UnityEngine.UI; // Para mexer com a UI do placar

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // Singleton para acessar de qualquer script

    [Header("UI do Placar")]
    public Text scoreText;

    private int score = 0;

    void Awake()
    {
        // Garante que só exista um ScoreManager
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddPoint(int amount)
    {
        score += amount;
        if (score < 0) score = 0; // não deixa ir abaixo de 0
        UpdateScoreUI();
    }

    public int GetScore()
    {
        return score;
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Pontos: " + score;
    }
}
