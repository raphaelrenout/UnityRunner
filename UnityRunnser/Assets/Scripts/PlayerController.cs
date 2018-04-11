using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody myRigidBody;
    private Transform myTransform;
    private Collider col;

    public float speed = 0.05f;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
            myRigidBody.velocity = transform.right * speed;

        if (Input.GetKey(KeyCode.Q))
            myRigidBody.velocity = -transform.right * speed;

        if (Input.GetKey(KeyCode.Z))
            myRigidBody.velocity = transform.forward * speed;

        if (Input.GetKey(KeyCode.S))
            myRigidBody.velocity = -transform.forward * speed;

        if (Input.GetKey(KeyCode.Space))
            myRigidBody.velocity = transform.up * speed;

        OnTriggerEnter(col);
	}

    void OnTriggerEnter(Collider col) {
        if (col.name == "WaterBasicDaytime")
        {
            Physics.gravity /= 100;
            speed = 300;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Water")
        {
            Physics.gravity *= 10;
        }
    }
}
