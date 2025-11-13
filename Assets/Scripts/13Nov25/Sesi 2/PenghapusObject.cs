using System.Collections;
using UnityEngine;

public class PenghapusObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 5);
        //StartCoroutine(HapusObject());
    }

    // IEnumerator HapusObject()
    // {
    // yield return new WaitForSeconds(2);
    // Destroy(gameObject);
    // }
}
