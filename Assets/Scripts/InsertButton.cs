using UnityEngine;
using UnityEngine.UI;

public class InsertButton : MonoBehaviour, IButton
{
    char character;
    InputField inputField;

    public void Initialize(char character, InputField inputField)
    {
        this.character = character;
        this.inputField = inputField;
    }

    public void OnPressed()
    {
        inputField.text += character;
    }
}