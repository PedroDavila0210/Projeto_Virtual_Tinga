using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHome : MonoBehaviour
{

    public void ButtonPainel(){
        SceneManager.LoadScene(1);

    }

    public void QuitGame(){
        Application.Quit();
    }

}
