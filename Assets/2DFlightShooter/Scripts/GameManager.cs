using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isPlay = false;
    public static int score;
    public static int bestScore;

    public GameObject popUP;
    public GameObject endPanel;
    public GameObject mainPanel;

    private void Awake()
    {
        isPlay = false;
        score= 0;

        popUP.SetActive(false);
        endPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            popUP.SetActive(true);
        }
    }

    public static void SaveScore()
    {
        PlayerPrefs.SetInt("Best", bestScore);
    }

    public static void LoadScore()
    {
        bestScore =
        PlayerPrefs.GetInt("Best", 0);
    }

    public void GameOver()
    {
        isPlay = false;
        endPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
}
