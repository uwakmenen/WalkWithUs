using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject poin;
    private GameObject[] kotak;
    private GameObject main;
    float[] jarak;
    private GameObject[] tongSampah;
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
        //pick up item
        for (int i = 0; i < jarak.Length; i++)
        {
            jarak[i] = Vector3.Distance(transform.position, kotak[i].transform.position);
            if (main == null)
            {
                if (jarak[i] > 0 && jarak[i] < 0.5)
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

        //melepaskan item yang dipegang
        for (int i = 0; i < tongSampah.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                //jika dekat dengan tong sampah, akan masuk tong sampah
                if (Vector3.Distance(transform.position, tongSampah[i].transform.position) <= 2)
                {
                    if (main != null)
                    {
                        main.transform.SetParent(tongSampah[i].transform);
                        main.transform.localPosition = new Vector3(0, 1, 0);
                        main = null;

                    }

                }
                //jika tidak dia akan melepas barang saja
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

}