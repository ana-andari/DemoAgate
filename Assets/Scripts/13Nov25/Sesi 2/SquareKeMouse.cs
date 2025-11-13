using UnityEngine;

public class SquareKeMouse : MonoBehaviour
{
    public Transform CubeTransform;
    public Vector2 PosisiKlik;

    void Update()
    {
        // Geser Objek ke kursor mouse
        // Vector2 WorldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // CubeTransform.position = Vector2.MoveTowards(CubeTransform.position, WorldMousePosition, 0.1f);

        // Geser Objek ke klik mouse
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PosisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        CubeTransform.position = Vector2.MoveTowards(CubeTransform.position, PosisiKlik, 0.1f);

    }
}
