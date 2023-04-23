using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Lives : MonoBehaviour
{
    //References
    public ScoreManager scoreManager;
    public Text textToChange;


    private void Start()
    {
        scoreManager = GameObject.Find("scoreManager").GetComponent<ScoreManager>();

    }

    private void Update()
    {
        textToChange.text = scoreManager.lives.ToString();
    }
}
