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
        
        var button = raycastHit.collider.GetComponent<IButton>();
        if (button == null)
        {
            return;
        }

        button.OnPressed();
    }
}