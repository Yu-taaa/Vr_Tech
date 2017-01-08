using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Serialize : MonoBehaviour {

	List<string> array = new List<string>();
	public Text text;
	public InputField inputField;
	string str;

	[SerializeField]
	string count;


	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			if (Physics.Raycast (ray, out hit)) {
				//hitしたオブジェクトの値を取得
				if (hit.transform.gameObject.tag == "key") {
//					string hogeComp = (string)hit.transform.gameObject.GetComponent<count>();
//					var serializedObject = new UnityEditor.SerializedObject(hogeComp);
//					var roundEndUi = serializedObject.FindProperty("hogeLabel").objectReferenceValue as UIWidget;
//					//					print (str);
					str = hit.transform.gameObject.GetComponent<Serialize>().count;
						array.Add (str);
					print (str);
				} else if (hit.transform.gameObject.tag == "cube") {
					string num = array [array.Count - 1];
					array.Remove (num);
				} else if (hit.transform.gameObject.tag == "blue") {
					array.Clear();

				}


				string username = "";

				foreach (string word in array)
				{
					username += word;
				}



				if (username != null && inputField != null)
				{
					
					//text.text = username;
//					 
					inputField.text = username;
					str = inputField.text;
					//					フィールドにテキスト入力
					text.text = str;
//					//					inputField.text = "";
//					//					inputField.text = "";
//					//					enter押してフィールドの文字をカラに
				}
			}
		}


	}
	//Buttonを押したときにinputField.textを空にする
//	public void InputButton(){
//		if (inputField.text != null) {
//			print ("username");
//			//UserName取得
//			string UserName = str;
//			print (UserName);
//			inputField.text = "";
//
//
//		}
//	}
}
