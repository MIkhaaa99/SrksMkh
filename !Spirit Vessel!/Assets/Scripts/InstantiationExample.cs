using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationExample : MonoBehaviour
{

    public GameObject myPrefab;
    public float SpawnTime;

    void Start()
    {
        InvokeRepeating("SpawnBlock", 0, SpawnTime);
    }

    void SpawnBlock()
    {
        GameObject block = Instantiate(myPrefab, transform.position, transform.rotation) as GameObject;
    }
}
