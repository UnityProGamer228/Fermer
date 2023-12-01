
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   public TextMeshProUGUI scoreText;
   public TextMeshProUGUI GameOverText;
   public GameObject restartButten;
   public int score;
   public bool GameOver;
    // Start is called before the first frame update

    void Start()
    {
    score=0;
    scoreText.text="score: "+score;    
    GameOverText.gameObject.SetActive(false);
    restartButten.gameObject.SetActive(false);
    GameOver=false;
    }
    public void IncreaseScore(int addScore)
    {
        score+=addScore;
        scoreText.text="score: "+score;
  
        
    } 
     public void minusScore(int mScore)
    {
        score-=mScore;
        scoreText.text="score: "+score;
        if(score<0)
        {
        GameOver=true;
        GameOverText.gameObject.SetActive(true);
    restartButten.gameObject.SetActive(true);
        }
        
    } 
   public void RestartGame()
   {
    SceneManager.LoadScene("Prototype 2");
   }
    
    void Update()
    {
        
    }
}  
