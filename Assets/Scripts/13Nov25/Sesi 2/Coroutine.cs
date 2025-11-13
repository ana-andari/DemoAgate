using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CobaCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    //function IEnumerator untuk coroutine
    IEnumerator CobaCoroutine()
    {
        Debug.Log("Perintah 1");
        yield return new WaitForSeconds(5); //perintah dijeda 5 detik
        Debug.Log("Perintah 2");
    }
}
