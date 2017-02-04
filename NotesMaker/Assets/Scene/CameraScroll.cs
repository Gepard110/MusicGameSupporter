using UnityEngine;
using System.Collections;

public class CameraScroll : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -5) {
			if (Input.GetKey ("up")) {
				this.transform.position += new Vector3 (0, speed + Time.deltaTime, 0);
			}
		}
		if(Input.GetKey("down")){
			this.transform.position -= new Vector3(0, speed + Time.deltaTime, 0);
		}
	}
}
