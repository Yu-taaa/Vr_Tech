using UnityEngine;
using UnityEngine.UI;

public class InsertButton : MonoBehaviour, IButton
{
	public char key;
    char character;
    InputField inputField;

    public void Initialize(char word, InputField inputField)
    {
        this.character = word;
        this.inputField = inputField;
    }

	//ボタンが押されたら1文字inputFieldの中にいれる
    public void OnPressed()
	{
		if (inputField != null) {
			inputField.text += character;
		}
	}
}