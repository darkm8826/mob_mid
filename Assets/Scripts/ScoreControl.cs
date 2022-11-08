using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Text TextScore;
    public static float Score = 0;
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = "Score:" + Score;
    }
}
