using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text ScoreText;
    public Text highScoreText;

    int Score = 0;
    int progress = 5;
    int highScore = 0;
    public Slider healthBar;
    private void Awake(){
        instance = this;
    }
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        healthBar.value = progress;
        ScoreText.text = Score.ToString() + " POINTS";
        highScoreText.text = "BEST "  + highScore.ToString();
    }
    public void health(){
        progress--;
        healthBar.value = progress;
    }
    public void Display(int add){
        ScoreText.text = add.ToString() + " POINTS";
        if (highScore < add){
            PlayerPrefs.SetInt("highscore", add);
        }
    }
}
