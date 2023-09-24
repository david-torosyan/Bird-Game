using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float floatNumber = 10;
    public LogicScript logic;
    public bool isBirdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {
            myRigidbody.velocity = Vector2.up * floatNumber;
        }
        if (transform.position.y > 31 || transform.position.y < -31)
        {
            isBirdAlive = false;
            logic.gameOver();
        }


    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        isBirdAlive = false;
        logic.gameOver();
    }

}
