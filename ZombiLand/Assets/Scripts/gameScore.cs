using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameScore : MonoBehaviour
{

    public static int Score = 0;
    public string scoreString = "Score";
    public Text textScore;

    public static gameScore GameScore;

    private void Awake()
    {
        GameScore = this;
    }
    void Start()
    {

        Score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(textScore != null)
        {

            textScore.text = scoreString + Score.ToString();
        }
        
    }
}
