using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Block> path;


    // Use this for initialization
    void Start()
    {

        StartCoroutine(PrintAllWaypoints());

    }

    IEnumerator PrintAllWaypoints()
    {
        foreach (Block waypoint in path)
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(1f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
