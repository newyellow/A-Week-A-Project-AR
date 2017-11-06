using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class testLoad : MonoBehaviour {

	public int indexToLoad = 0;

	void Awake () {

		string[] dataToLoad = VuforiaConfiguration.Instance.DatabaseLoad.DataSetsToActivate;

		for (int i = 0; i < dataToLoad.Length; i++) {
			Debug.Log ("DATASET:: " + dataToLoad [i]);
		}
		string[] onlyLoad = new string[1];
		onlyLoad[0] = dataToLoad [indexToLoad];

		VuforiaConfiguration.Instance.DatabaseLoad.DataSetsToActivate = onlyLoad;
		VuforiaConfiguration.Instance.DatabaseLoad.DataSetsToLoad = onlyLoad;

	}

	// Use this for initialization
//	void Start () {
//		string[] dataToLoad = VuforiaConfiguration.Instance.DatabaseLoad.DataSetsToActivate;
//		string[] onlyLoad = new string[1];
//		onlyLoad[0] = dataToLoad [indexToLoad];
//
//		VuforiaConfiguration.Instance.DatabaseLoad.DataSetsToActivate = onlyLoad;
//		VuforiaConfiguration.Instance.DatabaseLoad.DataSetsToLoad = onlyLoad;
//	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (VuforiaARController.Instance.HasStarted);
	}
}
