using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject poin;
    private GameObject[] kotak;
    private GameObject main;

    // Start is called before the first frame update
    void Start()
    {
        kotak = GameObject.FindGameObjectsWithTag("halangan");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < kotak.Length; i++)
        {
            if (Vector3.Distance(this.transform.position, kotak[i].transform.position) <= 2f)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (main == null)
                    {
                        
                        kotak[i].transform.SetParent(poin.transform);
                        main = kotak[i];
                        kotak[i].transform.localPosition = Vector3.zero;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (Input.GetKeyDown(KeyCode.G))
                {
                    if (main != null)
                    {
                        poin.transform.DetachChildren();
                        main = null;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }


    void pickUp()
    {
        
    }

    void Drop()
    {
       
    }
}
