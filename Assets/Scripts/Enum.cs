using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Enum : MonoBehaviour {

	List<string> array = new List<string>();
	public Text text;
	public InputField inputField;
	string str;


	public  enum KeyType {
		red, green, yellow, black, cube
	}

	public KeyType keytype;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			if (Physics.Raycast (ray, out hit)) {
				//hitしたオブジェクトの値を取得
				if (hit.transform.gameObject.tag == "key") {
					Enum key = (Enum)hit.transform.gameObject.GetComponent<Enum> ();
//					print (key);
					var str = key.keytype;
//					print (str);
					string command = str.ToString ();
					array.Add (command);
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
					
					inputField.text = username;
					str = inputField.text;
					//					フィールドにテキスト入力
					text.text = str;
//					inputField.text = "";
					//					inputField.text = "";
					//					enter押してフィールドの文字をカラに
		      	}
			}
      }


  }
	//Buttonを押したときにinputField.textを空にする
	     public void InputButton(){
		       if (inputField.text != null) {
			//UserName取得
			     string UserName = str;
			     print (UserName);
			     inputField.text = "";


		        }
	    }
}

	
//
//	public void Button(){
//		string username = "";
//		foreach (string word in array)
//		{
//			username += word;
//		}
//		if (username != null)
//		{
//			inputField.text = username;
//			str = inputField.text;
//			//					フィールドにテキスト入力
//			text.text = str;
//			//					inputField.text = "";
//			//					enter押してフィールドの文字をカラに
//        }
//     }
//}
//	



