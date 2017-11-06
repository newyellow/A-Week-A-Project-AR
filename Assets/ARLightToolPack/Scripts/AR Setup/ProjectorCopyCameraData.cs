using UnityEngine;
using System.Collections;

public class ProjectorCopyCameraData : MonoBehaviour {

	public Camera targetCamera;

	// Use this for initialization
	IEnumerator Start () {
		for (int i = 0; i < 50; i++) {
			AdjustCam ();

			yield return new WaitForSeconds (0.1f);
		}
	}

	void AdjustCam () {
		Projector _projector = gameObject.GetComponent<Projector> ();

		_projector.aspectRatio = targetCamera.aspect;
		_projector.fieldOfView = targetCamera.fieldOfView;
	}
}
