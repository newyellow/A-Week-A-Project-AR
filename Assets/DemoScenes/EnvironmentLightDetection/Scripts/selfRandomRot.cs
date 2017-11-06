using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfRandomRot : MonoBehaviour {

	public float speed = 100.0f;
	Vector3 rotDir;

	// Use this for initialization
	void Start () {
		rotDir = Random.rotation.eulerAngles.normalized;	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotDir * speed);
	}
}
