using JetBrains.Annotations;
using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField]
    Player[] ArrayPlayer;
    public string[] ArrayNama = { "Aan", "Ani", "Ana" };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(ArrayNama[1]); // Menampilkan array index ke 1

        ArrayNama[0] = "Fadhli"; //mengubah isi array index ke 0
        Debug.Log(ArrayNama[0]);

        Debug.Log(ArrayNama.Length); //Menampilkan panjang array

        for (int index = 0; index < ArrayNama.Length; index++)
        {
            Debug.Log(ArrayNama[index]);
        }

        //cara lain menampilkan array player
        foreach (Player player in ArrayPlayer)
        {
            Debug.Log(player.Name);
        }
        Debug.Log(ArrayPlayer.Length);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
