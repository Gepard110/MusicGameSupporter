using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NoteCreat : MonoBehaviour
{
	public Setting setting;
	public GameObject notePre;
	GameObject[,] notes = new GameObject[1, 1];


	// Use this for initialization
	void Start ()
	{
		setting = GameObject.Find ("Manager").GetComponent<Setting> ();

		notes = new GameObject[setting.row, setting.column]; 

		for (int i = 0; i < setting.row; i++) {
			for (int j=0; j<setting.column; j++) {
				notes [i, j] = Instantiate (notePre) as GameObject;
				notes [i, j].transform.position = new Vector3 ((j + 1) * (10.0f / (setting.column)), -i, 0); 
				notes [i, j].name = "Note" + i + j;
				notes [i, j].transform.localScale = new Vector3 (10f / setting.column, 1, 1);
				notes [i, j].transform.localScale *= 0.9f;
				Debug.Log (i + " " + j + " = " + notes [i, j]);
			}
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("h")) {
			output ();
		}
	}

	public void output ()
	{
		string[,] data = new string[setting.row, setting.column];
		for (int i = 0; i < setting.row; i++) {
			for (int j=0; j<setting.column; j++) {
				notestatus ns = notes [i, j].GetComponent<notestatus> ();
				data [i, j] = ns.statusNum [ns.arrayIndex].ToString ();
			}
		}
		fileManager.WriteData ("Assets/test.csv", data);
	}

}
