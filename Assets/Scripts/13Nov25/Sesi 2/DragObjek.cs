using UnityEngine;

public class DragObjek : MonoBehaviour
{

    void OnMouseDrag()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // untuk gerak kiri kanan saja 
        // Vector2 SquarePosition = new Vector2(worldMousePosition.x, transform.position.y);

        // Membatasi mouse tidak melebihi dinding layar kiri dan kanan
        // SquarePosition.x = Mathf.Clamp(SquarePosition.x, -8,8),
        transform.position = worldMousePosition;
    }


}
