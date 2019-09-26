using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

    public MosquitoRigController mosquito;

	// Update is called once per frame
	void FixedUpdate () {
        Vector3 direction = Input.GetAxis("Forward") * transform.forward + Input.GetAxis("Vertical") * Vector3.up + Input.GetAxis("Horizontal") * transform.right;
        Vector3 torqueDirection = Vector3.up * Input.GetAxis("Rotate");
        mosquito.Command(direction, torqueDirection);
	}
}
