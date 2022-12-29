using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private bool Pause = false;
    private bool Hint = false;
    public GameObject pausePanel;
    public GameObject hintPanel;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    public void Win(bool active)
    {
        FindObjectOfType<StarterAssets.ThirdPersonController>().enabled = active;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!Pause)
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                pausePanel.SetActive(true);
                Pause = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                pausePanel.SetActive(false);
                Pause = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!Hint)
            {
                Cursor.lockState = CursorLockMode.None;
                hintPanel.SetActive(true);
                Hint = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                hintPanel.SetActive(false);
                Hint = false;
            }
        }
    }
}
