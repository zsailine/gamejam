using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text scoreText;
    public void setup(int score){
        gameObject.SetActive(true);
        scoreText.text = score.ToString() + " POINTS";
    }
    public void restart(){
        SceneManager.LoadScene("SampleScene");
    }
    public void exit(){
        SceneManager.LoadScene("MainMenu");
    }
}