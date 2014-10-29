using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject go = Resources.Load ("Capsule") as GameObject;
		Instantiate (go);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate( 0f, 3f*Time.deltaTime, 0f );
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate( 0f, -3f*Time.deltaTime, 0f );
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate( -3f*Time.deltaTime, 0f, 0f );
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate( 3f*Time.deltaTime, 0f, 0f );
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate( -3f*Time.deltaTime, 0f, 0f );
		}
		if (Input.GetKey(KeyCode.LeftShift)) {
			transform.Translate( 0f, 0f, -3f*Time.deltaTime );
		}
		if (Input.GetKey(KeyCode.RightShift)) {
			transform.Translate( 0f, 0f, 3f*Time.deltaTime );
		}
		if (Input.GetKey(KeyCode.Space)) {
			transform.Rotate( 0f, 0f, 300f*Time.deltaTime );
		}
	}
}
