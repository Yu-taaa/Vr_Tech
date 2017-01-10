using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
	//boxにアタッチされたKeyboard.csのInputFieldにゲームオブジェクトInputFieldをアタッチしている
	//つまりここでのinputFieldはゲームオブジェクトInputField
    [SerializeField] InputField inputField;

    void Start()
    {
        // ABCDE button 5回繰り返す
        foreach (var x in Enumerable.Range(0, 5))
        {
			// ('A' + x)でABCDの順で変数を定義できる
            var character = (char) ('A' + x);
			//立方体や球体といった基本的な 3D モデルのスクリプトからの作成
            var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
			//20行目までで生成したobjの名前、位置を設定
            obj.name = character + " Button";
            obj.transform.SetParent(transform);
            obj.transform.position = Vector3.right * (x * 2 - 4.0f);

			//objにInsertButtonというコンポーネントを加え、InsertButtonクラスのInitializeを呼び出す。
			//8行目のinputFieldが引数
            obj.AddComponent<InsertButton>().Initialize(character, inputField);
			//呼び出し
            AddTextMesh(obj);
        }

        // BackSpace button
        {
			//立方体や球体といった基本的な 3D モデルのスクリプトからの作成
            var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
			//30行目までで生成したobjの名前、位置を設定
            obj.name = "BackSpace Button";
            obj.transform.SetParent(transform);
            obj.transform.position = new Vector3(4, 2, 0);
			//objにBackSpaceButtonというコンポーネントを加え、BackSpaceButtonクラスのInitializeを呼び出す
			//8行目のinputFieldが引数
			//AddComponent<BackSpaceButton>()でBackSpaceButtonスクリプトを参照
            obj.AddComponent<BackSpaceButton>().Initialize(inputField);
			//呼び出し
           AddTextMesh(obj);
        }
    }

	//生成したobjのテキスト情報を設定
    static void AddTextMesh(GameObject parent)
    {
        var obj = new GameObject("Text Mesh");
        obj.transform.SetParent(parent.transform, false);
        obj.transform.localScale = Vector3.one * 0.1f;

        var textMesh = obj.AddComponent<TextMesh>();
        textMesh.text = parent.name;
        textMesh.color = Color.black;
        textMesh.alignment = TextAlignment.Center;
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.fontSize = 30;
    }
}