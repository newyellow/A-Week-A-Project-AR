using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMeshData : MonoBehaviour {

	public bool applyNewMeshOnStart = false;

	// Use this for initialization
	void Start () {
		if (applyNewMeshOnStart)
			ApplyBGQuadMesh ();	
	}

	void ApplyBGQuadMesh () {
		MeshFilter _filter = gameObject.GetComponent<MeshFilter> ();
		Mesh _mesh = new Mesh ();

		Vector3[] verticies = new Vector3[4];
		verticies [0] = new Vector3 (-1.0f, 0.0f, 1.0f);
		verticies [1] = new Vector3 (1.0f, 0.0f, 1.0f);
		verticies [2] = new Vector3 (-1.0f, 0.0f, -1.0f);
		verticies [3] = new Vector3 (1.0f, 0.0f, -1.0f);

		Vector2[] uvs = new Vector2[4];
		uvs [0] = new Vector2 (0.0f, 0.0f);
		uvs [1] = new Vector2 (1.0f, 0.0f);
		uvs [2] = new Vector2 (0.0f, 1.0f);
		uvs [3] = new Vector2 (1.0f, 1.0f);

		int[] triangles = new int[6];
		triangles [0] = 0;
		triangles [1] = 3;
		triangles [2] = 2;
		triangles [3] = 3;
		triangles [4] = 0;
		triangles [5] = 1;

		_mesh.vertices = verticies;
		_mesh.uv = uvs;
		_mesh.triangles = triangles;

		_filter.mesh = _mesh;
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			MeshFilter _filter = gameObject.GetComponent<MeshFilter> ();
			Mesh _mesh = _filter.mesh;

			Vector3[] _verts = _mesh.vertices;
			Vector2[] _uvs = _mesh.uv;
			int[] tris = _mesh.triangles;

			Debug.Log ("VERTEX COUNT: " + _verts.Length);
			for (int i = 0; i < _verts.Length; i++) {
				Debug.Log (_verts [i]);
			}

			Debug.Log ("UV DATA:");
			for (int i = 0; i < _uvs.Length; i++)
				Debug.Log (_uvs [i]);

			Debug.Log ("tris");

			for (int i = 0; i < tris.Length; i++)
				Debug.Log (tris [i]);
		}
	}
}
