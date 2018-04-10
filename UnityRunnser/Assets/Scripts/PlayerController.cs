using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody myRigidBody;
    public float speed = 0.05f;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
            myRigidBody.AddForce(speed * Vector3.right);

        if (Input.GetKey(KeyCode.Q))
            myRigidBody.AddForce(speed * Vector3.left);

        if (Input.GetKey(KeyCode.Z))
            myRigidBody.AddForce(speed * Vector3.forward);

        if (Input.GetKey(KeyCode.S))
            myRigidBody.AddForce(speed * Vector3.back);

        if (Input.GetKey(KeyCode.Space))
            myRigidBody.AddForce(speed * Vector2.up);
	}
}
