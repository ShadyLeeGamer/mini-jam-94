using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    Vector3 startPos;

    [SerializeField] AudioClip mainMenuTrack;
    AudioStation audioStation;

    private void Start()
    {
        startPos = transform.position;
        audioStation = AudioStation.Instance;
        audioStation.StartNewMusicPlayer(mainMenuTrack, true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            StartCoroutine("GoToDefault");
        }
    }

    IEnumerator GoToDefault()
    {
        while (transform.position != startPos)
        {
            transform.position = Vector3.Lerp(transform.position, startPos, Time.deltaTime * 3f);
            yield return null;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}