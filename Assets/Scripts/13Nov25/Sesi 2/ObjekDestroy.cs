using UnityEngine;

public class ObjekDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D objekTerdeteksi = Physics2D.OverlapPoint(posisiKlik);  //yang dideteksi collidernya
            if (objekTerdeteksi != null)
            {
                Destroy(objekTerdeteksi.gameObject); //menghapus objeknya bukan collidernya
            }
        }
    }
}
