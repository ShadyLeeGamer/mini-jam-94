using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{

    public ScoreManager scoreManager;
    public Text textToChange;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("scoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        textToChange.text = scoreManager.score.ToString();
    }
}
