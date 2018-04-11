using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody myRigidBody;
    private Transform myTransform;

    public float speed = 0.05f;
    public float gravityStrength = 0.01f;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
        myTransform = transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
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

        myRigidBody.AddForce(-Vector3.up * gravityStrength);

	}

    void OnTriggerEnter(Collider col) {
        Debug.Log(col.name);
        if (col.tag == "Water")
        {
            gravityStrength = 1000f;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Water")
        {
            gravityStrength = 6000f;

        }
    }
}
