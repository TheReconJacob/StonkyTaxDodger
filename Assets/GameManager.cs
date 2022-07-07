using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject stonksFace;
    private Vector3 stonksPosition;
    void Start()
    {
        ShowMenuScreen();
        stonksPosition = stonksFace.transform.position;
    }

    public Canvas MenuCanvas;
    public void ShowMenuScreen()
    {
        MenuCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
        stonksFace.SetActive(false);
    }

    public void HideMenuScreen()
    {
        MenuCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        stonksFace.transform.position = stonksPosition;
        stonksFace.SetActive(true);
    }
}
