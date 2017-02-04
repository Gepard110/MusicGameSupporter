using UnityEngine;
using System.Collections;

public class Setting : MonoBehaviour
{
	public int column;
	public int row;

	// Use this for initialization
	void Awake ()
	{
		DontDestroyOnLoad (this);
	}

	void Start (){

	}
	
	// Update is called once per frame
	void Update (){
		if (Input.GetMouseButtonDown(0)) {
			// クリックしたスクリーン座標をrayに変換
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// Rayの当たったオブジェクトの情報を格納する
			RaycastHit hit = new RaycastHit();
			// オブジェクトにrayが当たった時
			if (Physics.Raycast(ray, out hit, 100f)) {
				// rayが当たったオブジェクトの名前を取得
				hit.collider.gameObject.GetComponent<notestatus>().OnTouch();
			}
		}
	}

	public  void GetColumn (string str)
	{
		if (str != "") {
			column = int.Parse (str);
			//Debug.Log (column);
		}
	}

	public void GetRaw (string str)
	{
		if (str != "") {
			row = int.Parse (str);
			//Debug.Log (raw);
		}
	}

	public void StartCreater ()
	{
		Application.LoadLevel ("main");
	}


	
}
