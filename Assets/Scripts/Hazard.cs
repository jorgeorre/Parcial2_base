﻿using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Hazard : MonoBehaviour
{
    private Collider2D myCollider;
    private object myRigidbody;

    [SerializeField]
    protected float resistance = 1F;

    protected float spinTime = 1F;

    // Use this for initialization
    protected void Start()
    {
        myCollider = GetComponent<Collider2D>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Bullet>() != null)
        {
            //TODO: Make this to reduce damage using Bullet.damage attribute
            resistance -= 1;

            if (resistance == 0)
            {
                OnHazardDestroyed();
            }
        }
        if (collision.gameObject.GetComponent<Shelter>() != null)
        {
            
            resistance -= 1;

            if (resistance == 0)
            {
                OnHazardDestroyed();
            }
        }

        if (collision != null)
        {
            OnHazardDestroyed();
        }
    }

    protected void OnHazardDestroyed()
    {
        //TODO: GameObject should spin for 'spinTime' secs. then disappear
        Destroy(gameObject);
    }

    
}