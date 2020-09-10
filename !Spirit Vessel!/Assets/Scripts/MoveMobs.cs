using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMobs : MonoBehaviour
{
    public GameObject finish;

    void Start()
    {
        finish = GameObject.Find("Finish");
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, finish.transform.position, Time.deltaTime);
    }
}
