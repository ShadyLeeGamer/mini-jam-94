using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int lives = 10;

    public AudioClip goodSFX, badSFX, liveUpSFX;
    AudioStation audioStation;

    public GameObject gameUI;
    public GameObject endUI;
    public GameObject gameOverController;

    private void Start()
    {
        audioStation = AudioStation.Instance;
    }

    protected void PlaySFX(AudioClip sfx)
    {
        audioStation.StartNewSFXPlayer(sfx, default, 1, 1, true);
    }

    public void increaseScore()
    {
        score += 1;
        PlaySFX(goodSFX);
    }

    public void decreaseScore()
    {
        if (score >= 1)
        {
            score -= 1;
        }
    }

    public void increaseLives()
    {
        lives += 1;
        PlaySFX(liveUpSFX);
    }

    public void decreaseLives()
    {
        lives -= 1;

        PlaySFX(badSFX);

        if (lives <= 0)
        {
            endOfGame();
        }
    }

    public void endOfGame()
    {
        //Disables Game UI to avoid overlapping
        gameUI.SetActive(false);

        //Enabling End Screen UI
        endUI.SetActive(true);

        gameOverController.SetActive(true);

        Time.timeScale = 0;
    }


}
