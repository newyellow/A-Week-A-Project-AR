using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleSelfRot : MonoBehaviour {

	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0.0f, speed * Time.deltaTime, 0.0f));
	}
}
