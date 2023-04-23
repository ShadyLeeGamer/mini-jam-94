using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameStarted = false;

    [SerializeField] AudioClip gameTrack;
    AudioStation audioStation;

    private void Start()
    {
        Time.timeScale = 1.0f;
        gameObject.GetComponent<Animator>().Play("GameStartCutscene");
        audioStation = AudioStation.Instance;
        audioStation.StartNewMusicPlayer(gameTrack, true);
    }

    public void StartGame()
    {
        gameStarted = true;
    }
}
