using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    public GameObject mainPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && gameObject.activeSelf)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        GameManager.isPlay = true;
        mainPanel.SetActive(true);
    }
}
