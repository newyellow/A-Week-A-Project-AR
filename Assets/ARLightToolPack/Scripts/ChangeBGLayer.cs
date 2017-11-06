using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGLayer : MonoBehaviour {

	public string toLayerName;


	IEnumerator Start () {

		while (true) {
			if (gameObject.GetComponentInChildren<Vuforia.BackgroundPlaneBehaviour> ()) {

				GameObject targetObj = gameObject.GetComponentInChildren<Vuforia.BackgroundPlaneBehaviour> ().gameObject;
				targetObj.layer = LayerMask.NameToLayer (toLayerName);


			}

			yield return null;
		}
	}

}
