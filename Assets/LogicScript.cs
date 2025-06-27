using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreTxt;
    public GameObject gameOverScreen;


    [ContextMenu("Add Acore")]
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
    }
    
}
