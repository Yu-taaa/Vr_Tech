using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
	//boxにアタッチされたKeyboard.csのInputFieldにゲームオブジェクトInputFieldをアタッチしている
	//つまりここでのinputFieldはゲームオブジェクトInputField
    [SerializeField] InputField inputField;

	//シーンやプレハブ、Assetとしてデータを編集・保存できるようになる 
	//インスペクター上のGUIで編集できるようになるので楽 
	//シリアライズできない=Unityエディタ上では扱いづらいと考えてOK 
	//publicとのちがいはprivateで他のコードからのアクセス不可



    void update()
	{
//		if (MouseInputManager.obj.tag == "key") {
//			print ("OK");
//			char word = MouseInputManager.obj.GetComponent<InsertButton> ().key;
//
//			//objにInsertButtonというコンポーネントを加え、InsertButtonクラスのInitializeを呼び出す。
//			//8行目のinputFieldが引数
//			//inputfieldをunityエディタでアタッチしてるので現在の入力している文字部分をもってこれる
//			MouseInputManager.obj.AddComponent<InsertButton> ().Initialize (word, inputField);
//			//呼び出し
////            AddTextMesh(obj);
//		} else if (MouseInputManager.obj.tag == "change") {
//			//objにBackSpaceButtonというコンポーネントを加え、BackSpaceButtonクラスのInitializeを呼び出す
//			//8行目のinputFieldが引数
//			//AddComponent<BackSpaceButton>()でBackSpaceButtonスクリプトを参照
//			MouseInputManager.obj.AddComponent<BackSpaceButton> ().Initialize (inputField);
//			//呼び出し
////           AddTextMesh(obj);
//		} else
//			return;
    }

	public void Hoge(GameObject obj){
		if (obj.tag == "key") {
			print ("OK");
			char word = obj.GetComponent<InsertButton> ().key;

			//objにInsertButtonというコンポーネントを加え、InsertButtonクラスのInitializeを呼び出す。
			//8行目のinputFieldが引数
			//inputfieldをunityエディタでアタッチしてるので現在の入力している文字部分をもってこれる
			obj.GetComponent<InsertButton> ().Initialize (word, inputField);
			//呼び出し
			//            AddTextMesh(obj);
		} else if (obj.tag == "change") {
			//objにBackSpaceButtonというコンポーネントを加え、BackSpaceButtonクラスのInitializeを呼び出す
			//8行目のinputFieldが引数
			//AddComponent<BackSpaceButton>()でBackSpaceButtonスクリプトを参照
			obj.GetComponent<BackSpaceButton> ().Initialize (inputField);
			//呼び出し
			//           AddTextMesh(obj);
		} else
			return;
	}

}