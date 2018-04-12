using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

	public bool hasRoundKey = false;
	public bool hasTriangularKey = false;
	public bool hasParchment = false;

	public ParticleSystem keyPS;
	public Animator animChest;
	public Animator animDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		Debug.Log(col.name);

		if (col.tag == "RoundKey")
		{
			Destroy(col.gameObject);
			keyPS.Play ();
			hasRoundKey = true;

		}

		if (col.tag == "TriangularKey")
		{
			Destroy(col.gameObject);
			keyPS.Play ();
			hasTriangularKey = true;
		}

		if (col.tag == "TreasureBox") {
			if (hasRoundKey && hasTriangularKey) {
				hasParchment = true;
				animChest.SetTrigger ("open");
			} else {
				animChest.SetTrigger ("notopen");
			}
		}

		if (col.tag == "Door") {
			if (hasParchment) {
				animDoor.SetTrigger ("open");
			} else {
				animDoor.SetTrigger ("notopen");
			}
		}
	}


		
}
