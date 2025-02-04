using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float elapsedTime = 0;

    public bool timerOn = false;

   [SerializeField] TextMeshProUGUI timerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn == true) 
        {
            elapsedTime += Time.deltaTime;

            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);

            timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        }
    }

    public void stopTimer() {

        timerOn = false;
    }

    public void resetTimer() {
        
        elapsedTime = 0;

    }

}
