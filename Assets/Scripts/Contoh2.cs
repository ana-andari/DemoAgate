using UnityEngine;

public class Contoh2 : MonoBehaviour
{
    int Number1 = 10;
    int Number2 = 7;
    int Number3 = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Result = Number1 + Number2;
        Debug.Log(Result);
        bool Hasil = Number1 == Number2;
        Debug.Log(Hasil);
        bool Hasil1 = (Number1 == Number2) && (Number1 > Number3); // and && or ||
        Debug.Log(Hasil1);
        bool Angka = ((1287 * 14 + 589) > (63 + 55 * 5)) && !(21 < 10);
        Debug.Log(Angka);
        Debug.Log(((1287 * 14 + 589) > (63 + 55 * 5)) && !(21 < 10));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
