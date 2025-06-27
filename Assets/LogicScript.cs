using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreTxt;
    public GameObject gameOverScreen;
    public float speedUpBy = 2;
    public int increment = 5;
    public float pipeSpeed = 5;
    public double spwanRate = 4;

    public int highScore;

    public Text highScoreText;


    void Start()
    {
        highScoreText.text = "Hight Score: " + highScore.ToString();
    }

    [ContextMenu("Add Score")]
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreTxt.text = score.ToString();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        if (score > highScore)
        {
            Debug.Log("High");
            highScore = score;
            PlayerPrefs.SetInt("highscore", score);
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highscore");
            PlayerPrefs.Save();

        }
        
    }

    public void IncreaseSpeed()
    {

        if (score == increment)
        {

            pipeSpeed += speedUpBy;
            //Debug.Log("Pipe Speed: " + pipeSpeed);
            increment += 5;

            if (increment >= 10 && increment % 5 == 0)
            {
                IncreaseSpawnRate();
            }

        }

    }

    public void IncreaseSpawnRate()
    {
        spwanRate -= 0.5;
    }
    void Update()
    {
        IncreaseSpeed();
    }
}
    

