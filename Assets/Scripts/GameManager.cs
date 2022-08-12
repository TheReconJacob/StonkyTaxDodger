using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject stonksFace;
    private Vector3 stonksPosition;
    public AudioClip stonkSound;
    public AudioClip deathSound;
    public AudioClip impactSound;
    public AudioClip goSound;
    public BackgroundScroller backgroundScroller;
    public Canvas MenuCanvas;
    public Canvas SubmitCanvas;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        ShowMenuScreen();
        stonksPosition = stonksFace.transform.position;
        audioSource.PlayOneShot(stonkSound, 4f);
    }
    public void ShowMenuScreen()
    {
        backgroundScroller.isGamePlaying(false);
        MenuCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
        stonksFace.SetActive(false);
    }

    public void ShowSubmitScreen()
    {
        audioSource.PlayOneShot(deathSound, 2f);
        audioSource.PlayOneShot(impactSound, 4f);
        backgroundScroller.isGamePlaying(false);
        SubmitCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
        stonksFace.SetActive(false);

    }

    public void HideMenuScreen()
    {
        audioSource.PlayOneShot(goSound, 4f);
        backgroundScroller.isGamePlaying(true);
        MenuCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        stonksFace.transform.position = stonksPosition;
        stonksFace.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
