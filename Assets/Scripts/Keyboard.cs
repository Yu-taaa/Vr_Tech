using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    [SerializeField] InputField inputField;

    void Start()
    {
        // ABCDE button
        foreach (var x in Enumerable.Range(0, 5))
        {
            var character = (char) ('A' + x);
            var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.name = character + " Button";
            obj.transform.SetParent(transform);
            obj.transform.position = Vector3.right * (x * 2 - 4.0f);
            obj.AddComponent<InsertButton>().Initialize(character, inputField);
            AddTextMesh(obj);
        }

        // BackSpace button
        {
            var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.name = "BackSpace Button";
            obj.transform.SetParent(transform);
            obj.transform.position = new Vector3(4, 2, 0);
            obj.AddComponent<BackSpaceButton>().Initialize(inputField);
            AddTextMesh(obj);
        }
    }

    void AddTextMesh(GameObject parent)
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