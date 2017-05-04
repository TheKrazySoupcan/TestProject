using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour {
    public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hitRef;
        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(transform.position,transform.forward,out hitRef))
            {
            hitRef.transform.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
            
        }
	}
}
