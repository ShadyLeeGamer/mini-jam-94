using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endOfGameController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene("BakingGame");
        }
    }
}
