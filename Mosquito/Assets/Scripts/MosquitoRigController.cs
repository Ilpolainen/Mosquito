using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosquitoRigController : MonoBehaviour {

    private Rigidbody rb;
    public float torqueForce = 1;
    public float accelerateForce = 1;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

    public void Command(Vector3 direction, Vector3 torqueDirection)
    {
        float forcescaler = 1;
       
        rb.AddForce(direction*accelerateForce / forcescaler);
        rb.AddTorque(torqueDirection*torqueForce);

    }
}
