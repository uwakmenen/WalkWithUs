using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BukaPintu : MonoBehaviour
{
    public Transform PlayerCamera;
    [Header("MaxDistance you can open or close the door.")]
    public float MaxDistance = 5;

    public Animator anim;



    void Update()
    {
        //This will tell if the player press F on the Keyboard. P.S. You can change the key if you want.
        if (Input.GetKeyDown(KeyCode.F))
        {
            Pressed();
            //Delete if you dont want Text in the Console saying that You Press F.
            Debug.Log("You Press F");
        }

        Debug.Log(Vector3.Distance(transform.position, GameObject.Find("Parking_barrier prefab").transform.position));
    }

    void Pressed()
    {
        if(Vector3.Distance(transform.position, GameObject.Find("Parking_barrier prefab").transform.position) <= 2f)
        {
            anim.SetBool("Opened", true);
        }
    }
}