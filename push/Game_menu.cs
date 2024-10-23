using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_menu : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitGame(){
        Application.Quit();
        Debug.Log("Exited");
    }
}
