using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDetectorToLight : MonoBehaviour {

	public RenderTexture renderT;
	public Texture2D colorTex;

	public Light environmentLight;
	public Light bounceLight;

	public Color lightColor;

	public void Start () {
		colorTex = new Texture2D (renderT.width, renderT.height);
	}

	public void Update () {
		DetectLight ();
	}

	public void DetectLight () {
		RenderTexture.active = renderT;
		colorTex.ReadPixels(new Rect(0, 0, renderT.width, renderT.height), 0, 0);
		colorTex.Apply();

		// get avg color
		lightColor = getAvgColor(colorTex);

		// map to light
		environmentLight.color = lightColor;
		bounceLight.color = lightColor;
	}

	Color getAvgColor (Texture2D _texture) {
		
		Color[] colors = _texture.GetPixels ();
		int nums = colors.Length;

		float sumR = 0.0f;
		float sumG = 0.0f;
		float sumB = 0.0f;

		for (int i = 0; i < colors.Length; i++) {
			sumR += colors [i].r;
			sumG += colors [i].g;
			sumB += colors [i].b;
		}

//		Debug.Log ("sum RGB: (" + sumR + "," + sumG + "," + sumB + ")");
		return new Color (sumR / (float)nums, sumG / (float)nums, sumB / (float)nums);
	}

}
