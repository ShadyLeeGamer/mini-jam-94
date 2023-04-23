using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Variables
    public float timeStart = 60f;

    //References
    public Text countdownText;
    public GameObject gameUI;
    public GameObject endUI;
    public GameObject itemSpawner;


    // Start is called before the first frame update
    void Start()
    {
        //Initialing UI text to value stored in timeStart (60)
        countdownText.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Counting down time
        timeStart -= Time.deltaTime;

        //Rounding number to make Comprehensive UI
        countdownText.text = Mathf.Round(timeStart).ToString();

        //If timer reaches 0
        if (timeStart <= 0)
        {
            //End game
            endOfGame();
        }
    }

    public void endOfGame()
    {
        //Disables Game UI to avoid overlapping
        gameUI.SetActive(false);

        //Enabling End Screen UI
        endUI.SetActive(true);

        Time.timeScale = 0;
    }

}
