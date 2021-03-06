﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisSpawner : HazardSpawner {

    public GameObject debrisTemplate;


    private void Start()
    {
        myCollider = GetComponent<Collider2D>();
        spawnFrequency = 2.8F;
        InvokeRepeating("SpawnEnemy", 0.2F, spawnFrequency);
    }

    private void SpawnEnemy()
    {
        if (debrisTemplate == null)
        {
            CancelInvoke();
        }
        else
        { 
            Instantiate(debrisTemplate, myCollider.GetPointInVolume(), transform.rotation);
        }
    }
}