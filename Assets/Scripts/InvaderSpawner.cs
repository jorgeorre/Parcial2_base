using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderSpawner : HazardSpawner {

    public GameObject invaderTemplate;


    private void Start()
    {
        myCollider = GetComponent<Collider2D>();
        spawnFrequency = 4.8F;
        InvokeRepeating("SpawnEnemy", 0.2F, spawnFrequency);
    }

    private void SpawnEnemy()
    {
        if (invaderTemplate == null)
        {
            CancelInvoke();
        }
        else
        { 
            Instantiate(invaderTemplate, myCollider.GetPointInVolume(), transform.rotation);
        }
    }
}