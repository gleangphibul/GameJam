using UnityEngine;
using System.Collections;
// using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void SetUp(int time)
    {
        //pointsText.text = "Time:" + time.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
