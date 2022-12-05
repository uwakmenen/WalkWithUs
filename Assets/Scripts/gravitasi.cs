using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitasi : MonoBehaviour
{
    public GameObject closest = null;
    public float distance = Mathf.Infinity;

    private void Update()
    {
        FindClosestEnemy();
    }
    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("halangan");
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
