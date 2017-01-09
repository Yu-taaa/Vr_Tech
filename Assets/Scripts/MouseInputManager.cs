using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseInputManager : MonoBehaviour
{
    [SerializeField] InputField inputField;

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
        
        var keyTop = raycastHit.collider.GetComponent<KeyTop>();
        if (keyTop == null)
        {
            return;
        }

        inputField.text += keyTop.Text;
    }
}