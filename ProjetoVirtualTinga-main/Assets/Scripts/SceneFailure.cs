using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFailure : MonoBehaviour
{
    public void ButtonBackMenu(){
         SceneManager.LoadScene(0);
    }

    public void QuitGame(){
        Application.Quit();
    }


}
