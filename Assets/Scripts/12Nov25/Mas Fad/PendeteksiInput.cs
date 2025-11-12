using System;
using UnityEngine;
using UnityEngine.Events;

public class PendeteksiInput : MonoBehaviour
{
    public UnityEvent inputEven;  //even dari unity listen bisa dilakukan lewat inspector

    //public Action inputEven; //even dari C#
    //public Score objectScore; //komunikasi 2 script melalui objek di inspector
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputEven.Invoke();
            //objectScore.AddScore();
        }
    }
}
