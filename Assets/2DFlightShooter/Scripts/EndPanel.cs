using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndPanel : MonoBehaviour
{
    public Text score;
    public Text bestScore;

    private void OnEnable()
    {
        score.text = GameManager.score.ToString();

        if (GameManager.score >= GameManager.bestScore)
        {
            GameManager.bestScore = GameManager.score;
        }

        bestScore.text =
            string.Format("Best : {0:D4}", GameManager.bestScore);

        GameManager.SaveScore();
    }

    void Update()
    {
        if (!gameObject.activeSelf) return;

        if (Input.GetKeyDown(KeyCode.P))
        {
            NewGame();
        }
    }

    void NewGame()
    {
        SceneManager.LoadScene(0);
    }
}
