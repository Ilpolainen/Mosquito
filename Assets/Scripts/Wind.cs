using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {

    private Rigidbody rb;
    public float windThrust;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Random.onUnitSphere);
	}
	
	// Update is called once per frame
	private void FixedUpdate () {
        rb.AddForce(gameObject.GetComponent<WindSensor>().GetVelocity() * windThrust);
	}
}
