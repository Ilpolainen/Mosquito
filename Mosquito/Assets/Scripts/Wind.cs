using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {

    private Rigidbody rb;
    public float windThrust;
    public WindSensor sensor;
	// Use this for initialization
	void Start () {
        if (sensor == null)
        {
            sensor = gameObject.GetComponent<WindSensor>();
            Debug.LogWarning("Specific WindSensor for Wind is not specified for gameObject: " + gameObject.name + "! Trying to search it automatically from the componenets.");
            if (sensor == null)
            {
                Debug.LogWarning("NO SENSOR FOUND FOR " + gameObject.name);
            }
        }
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Random.onUnitSphere);
	}
	
	// Update is called once per frame
	private void FixedUpdate () {
        rb.AddForce(sensor.GetVelocity() * windThrust);
	}
}
