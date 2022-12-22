using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Win(bool active)
    {
        FindObjectOfType<StarterAssets.ThirdPersonController>().enabled = active;
    }
}
