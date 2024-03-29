﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tetrisObjects;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandom();
    }

    public void SpawnRandom(){
        int index = Random.Range(0, tetrisObjects.Length);
        Instantiate(tetrisObjects[index],transform.position, Quaternion.identity);
    }
}
