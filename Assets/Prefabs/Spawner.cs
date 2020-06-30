﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject prefab;

    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 3f);
    }
    void Spawn()
    {
        Vector3 position = new Vector3(0f, 0f, 0f);
        position.y = Random.Range(3f, 4f);
        position.x = Random.Range(-6f, 6f);
        Instantiate(prefab, position, Quaternion.identity);
    }
}
