using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneSuccess : MonoBehaviour
{
    public TextMeshProUGUI registerScoreText;
    public TextMeshProUGUI registerTimerText; // Texto de UI para o tempo levado

    void Start()
    {
        ShowHub();
    }

    private void ShowHub()
    {
        // Exibe a pontuação
        registerScoreText.text = "Você completou com " + ScenePainel.score + " pontos.";

        // Exibe o tempo formatado no estilo 00:00:00
        registerTimerText.text = "Tempo levado: " + FormatTime(ScenePainel.timeTaken);
    }

    private string FormatTime(float time)
    {
        int hours = Mathf.FloorToInt(time / 3600);
        int minutes = Mathf.FloorToInt((time % 3600) / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }
    public void BackMenu()
    {
        SceneManager.LoadScene(0); // Carrega a cena do menu principal
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
