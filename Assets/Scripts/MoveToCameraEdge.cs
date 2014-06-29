using UnityEngine;
using System.Collections;

public class MoveToCameraEdge : MonoBehaviour {
	public enum HorizEdge { None, Left, Right }
	public enum VertEdge { None, Top, Bottom }

	public Vector3 offset;
	public HorizEdge horizontalSnap;
	public VertEdge verticalSnap;

	// Use this for initialization
	void Start () {
		var cam = Camera.main;
		var hOver2 = cam.orthographicSize;
		var wOver2 = cam.aspect * hOver2;

		var pos = transform.position;

		if (horizontalSnap == HorizEdge.Left) {
			pos.x = -wOver2;
		} else if (horizontalSnap == HorizEdge.Right) {
			pos.x = wOver2;
		}

		if (verticalSnap == VertEdge.Top) {
			pos.y = hOver2;
		} else if (verticalSnap == VertEdge.Bottom) {
			pos.y = -hOver2;
		}

		pos += offset;

		transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
