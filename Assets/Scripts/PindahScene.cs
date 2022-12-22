using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{

    public void switchscene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void KeluarGame()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }
}