using UnityEngine;
using UnityEngine.UI;

public class BackSpaceButton : MonoBehaviour, IButton
{
    InputField inputField;
	public char key;

    public void Initialize(InputField inputField)
    {
        this.inputField = inputField;
    }

    public void OnPressed()
	{
		if (inputField != null) {
			if (inputField.text.Length == 0) {
				return;
			}
			//文字列の最後の１文字の前までの文字を取得してる
			inputField.text = inputField.text.Substring (0, inputField.text.Length - 1);
		}
    }
}
