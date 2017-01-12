using UnityEngine;
using UnityEngine.UI;


public class MouseInputManager : MonoBehaviour
{
	public static GameObject obj;
	public InputField inputField;

    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        RaycastHit raycastHit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out raycastHit))
        {
            return;


        }

		obj = raycastHit.collider.gameObject;
		Keyboard keyboard = obj.GetComponent<Keyboard> ();
		keyboard.Hoge (obj);
		//GetComponent<>でオブジェクト(衝突物)のスクリプトを参照してる
		//ここでrayが衝突したオブジェクトの情報を取得している
        var button = raycastHit.collider.GetComponent<IButton>();

		print (button);
        if (button == null)
        {
            return;
        }
		//rayの当たったオブジェクトにアタッチされてるスクリプトのpublic void OnPressed()を呼び出してる
		 button.OnPressed();

    }

	public void InputButton(){
		string name = inputField.text;
		print (name);

		inputField.text = "";
//		string username = (string)name;
//		print (username);

//		string name = inputField.text;
//		print ();

		}

	}
