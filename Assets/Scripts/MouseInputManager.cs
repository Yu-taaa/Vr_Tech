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
        
        var button = raycastHit.collider.GetComponent<IButton>();
        if (button == null)
        {
            return;
        }

        button.OnPressed();
    }
}