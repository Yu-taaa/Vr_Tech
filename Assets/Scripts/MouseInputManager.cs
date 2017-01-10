using UnityEngine;

public class MouseInputManager : MonoBehaviour
{
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
}