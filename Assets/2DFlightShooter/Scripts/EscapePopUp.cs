using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapePopUp : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.isPlay = false;
        Time.timeScale = 0;
    }

    void Update()
    {
        if (gameObject.activeSelf == false) return;

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.N))
        {
            gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        GameManager.isPlay = true;
        Time.timeScale = 1;
    }
}
