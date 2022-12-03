using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject poin;
    private GameObject[] kotak;
    private GameObject main;
    float[] jarak;
    public GameObject[] tongSampah;
    // Start is called before the first frame update
    void Start()
    {
        kotak = GameObject.FindGameObjectsWithTag("halangan");
        tongSampah = GameObject.FindGameObjectsWithTag("tong sampah");
        jarak = new float[kotak.Length];
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < jarak.Length; i++)
        {
            jarak[i] = Vector3.Distance(transform.position, kotak[i].transform.position);
            if (main == null)
            {
                if (jarak[i]>0&&jarak[i]<0.5)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        main = kotak[i];
                        kotak[i].transform.SetParent(poin.transform);
                        kotak[i].transform.localPosition = Vector3.zero;
                    }
                }
            }
        }

        for (int i = 0; i < tongSampah.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                if (Vector3.Distance(transform.position, tongSampah[i].transform.position) <= 2)
                {
                    if (main != null)
                    {
                        //Destroy(poin.transform.GetChild(0).gameObject);
                        main = null;
                    }

                }
                else
                {
                    if (main != null)
                    {
                        poin.transform.DetachChildren();
                        main = null;
                    }

                }

            }


        }
    }

    void checknearest()
    {
        
    }
}
