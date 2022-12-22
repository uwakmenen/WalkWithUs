using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TextWaktu;
    public float Waktu = 100;
    public bool GameAktif = true;

    public GameObject Kalah;

    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextWaktu.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    float s;

    private void Update()
    {
        SetText();

        if(GameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }
        if(GameAktif && Waktu <= 0)
        {
            Debug.Log("Game Kalah");
            FindObjectOfType<StarterAssets.ThirdPersonController>().enabled = false;
            GameAktif = false;
            Kalah.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}