﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beecontroller : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    public float bunnyForce = 500f;


    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonUp("Jump"))
        {
            myRigidBody.AddForce(transform.up * bunnyForce);

        }


    }

}
