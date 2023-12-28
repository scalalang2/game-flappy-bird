using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void Update()
    {
        if (birdIsAlive && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * flapStength;   
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
