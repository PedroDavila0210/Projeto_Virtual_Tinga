using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImageTargets : MonoBehaviour
{
    private float startTime; // Tempo quando a pergunta foi exibida

    // Chama esta função quando a pergunta aparecer
    void Start()
    {
        startTime = Time.time; // Registra o tempo em que a pergunta começou
    }

    // Tempo para mudar de questão:

    // Tempo padrão de 2 segundos
    public void GoNextQuestion10(){
        Invoke("NextQuestion", 10f);
    }

    public void GoNextQuestion15(){
        Invoke("NextQuestion", 15f);
    }

    public void GoNextQuestion25(){
        Invoke("NextQuestion", 25f);
    }


    public void NextQuestion(){
        // Aumenta o tempo do jogador
        ScenePainel.score += 10;

        // Mostra a próxima questão
        GameObject.Find("ScenePainel").GetComponent<ScenePainel>().ShowQuestion();

        // Destrói o objeto da pergunta atual
        Destroy(gameObject);
    }
}