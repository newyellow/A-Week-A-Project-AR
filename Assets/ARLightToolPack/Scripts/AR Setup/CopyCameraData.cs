using UnityEngine;
using System.Collections;

public class CopyCameraData : MonoBehaviour {

	public Camera targetCamera;

	// Use this for initialization
	IEnumerator Start () {
		for (int i = 0; i < 50; i++) {
			AdjustCam ();

			yield return new WaitForSeconds (0.1f);
		}
	}

	void AdjustCam () {
		Camera _cam = gameObject.GetComponent<Camera> ();

		_cam.aspect = targetCamera.aspect;
		_cam.fieldOfView = targetCamera.fieldOfView;
	}
}
