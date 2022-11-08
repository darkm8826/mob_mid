using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreControl : MonoBehaviour
{
    public Text TextScore;
    public Text TextHP;
    public static float Score = 0;
    public Transform TeleportSpot1;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    private bool choice = false;
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = "Score:" + Score;
        TextHP.text = "HP:" + Player.hp;
        if (Score >= 400)
        {
            TeleportSpot1.transform.position = new Vector3(TeleportSpot1.transform.position.x, 0, TeleportSpot1.transform.position.z);
            if (choice == false)
            {
                Button1.gameObject.SetActive(true);
                Button2.gameObject.SetActive(true);
                Button3.gameObject.SetActive(true);
                choice = true;
            }

        }
        if (Score >= 900)
        {
            SceneManager.LoadScene("END");
        }
    }
}
