using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpBar : MonoBehaviour
{
    public PlayerStats playerStats;

    private Image hpImage;
    public Text scoreText;


    void Start()
    {
        hpImage = GetComponent<Image>();
        hpImage.fillAmount = 1.0f;
    }

    void Update()
    {
        if(playerStats != null)
        {
            hpImage.fillAmount = playerStats.HpState();

            scoreText.text = GameManager.score.ToString();
        }
        else
        {
            hpImage.fillAmount = 0.0f;
        }
    }
}
