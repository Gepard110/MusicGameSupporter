using UnityEngine;
using System.Collections;

public class notestatus : MonoBehaviour {
	public int[] statusNum;

	[ HideInInspector]
	public int arrayIndex;
	Material mat;
	public Color[] noteColor;

	// Use this for initialization
	void Start () {
		mat = this.gameObject.GetComponent<MeshRenderer> ().material;
		ChangeColor (arrayIndex);

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnTouch(){
		arrayIndex += 1;
		if (arrayIndex == statusNum.Length) {
			arrayIndex = 0;
		}
		ChangeColor (arrayIndex);
	}

	void ChangeColor(int num){
		mat.color = noteColor [num];
	}
}
