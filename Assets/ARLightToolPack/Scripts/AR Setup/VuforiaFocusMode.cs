using UnityEngine;
using System.Collections;
using Vuforia;

public class VuforiaFocusMode : MonoBehaviour {

	public CameraDevice.FocusMode focusMode;

	// Use this for initialization
	void Start () {
		Vuforia.CameraDevice.Instance.SetFocusMode (focusMode);
	}
}
