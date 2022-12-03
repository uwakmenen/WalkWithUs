using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTranform;
    [SerializeField] private LayerMask pickUpLayerMask;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float pickUpDistance = 2f;
            if (Physics.Raycast(playerCameraTranform.position, playerCameraTranform.forward, out RaycastHit raycastHit, pickUpDistance))
            {
                Debug.Log(raycastHit.transform);
            }
        }
    }
}
