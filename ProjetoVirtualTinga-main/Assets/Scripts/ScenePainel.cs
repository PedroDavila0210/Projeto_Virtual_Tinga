using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScenePainel : MonoBehaviour
{
    public static int score;
    public static float timer; // Tempo de jogo
    public static string statusGame;
    
    // Novo campo para armazenar o tempo levado para completar a missão
    public static float timeTaken;

    // Recursos de UI
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timertext;

    public List<string> questions;
    public List<GameObject> imageTargets;

    private int index;
    private int qtdQuestions;
    private IEnumerator coroutine;

    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        index = -1;
        qtdQuestions = imageTargets.Count - 1;
        score = 0;
        timer = 86400f; // 24 horas em segundos
        statusGame = "Play";
        coroutine = WaitTimer();
        StartCoroutine(coroutine);
        ShowQuestion();
    }

    public void ShowQuestion()
    {
        index++;
        if (index <= qtdQuestions)
        {
            questionText.text = questions[index];
            Instantiate(imageTargets[index]);
        }
        else
        {
            // Calcula o tempo levado com base no tempo restante
            timeTaken = 86400f - timer; // 86400 segundos é o tempo total
            statusGame = "Win";
            SceneManager.LoadScene(3); // Carrega a cena de vitória
        }
    }

    private void ShowHud()
    {
        scoreText.text = "SCORE: " + score;

        int horas = Mathf.FloorToInt(timer / 3600);
        int minutos = Mathf.FloorToInt((timer % 3600) / 60);
        int segundos = Mathf.FloorToInt(timer % 60);

        timertext.text = string.Format("TIMER: {0:00}:{1:00}:{2:00}", horas, minutos, segundos);
    }

    private IEnumerator WaitTimer()
    {
        while (statusGame == "Play")
        {
            yield return new WaitForSeconds(1f);
            timer -= 1f;
            ShowHud();

            if (timer <= 0)
            {
                statusGame = "GameOver";
                SceneManager.LoadScene(2);
            }
        }
    }
}