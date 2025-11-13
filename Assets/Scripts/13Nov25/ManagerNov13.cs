using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class ManagerNov13 : MonoBehaviour
{
    public int skor;
    public TMP_Text textSkor;
    public SquareMove13 squareMove13;
    public GameObject bolaJatuh; // variabel perfab bola jatuh

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateTeksSkor();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Klik Kiri");
            //Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log("Posisi ada di " + vector.ToString());
            TambahSkor();
            UpdateTeksSkor();
            //ToggleKiriKanan();
            squareMove13.isMoveRight = false;
            MunculDariAtas();


        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Klik Kanan");
            KurangSkor();
            UpdateTeksSkor();
            squareMove13.isMoveRight = true;
        }
    }

    void TambahSkor()
    {
        skor++;
        Debug.Log("Integer Skor Bertambah");
    }

    void KurangSkor()
    {
        skor--;
        Debug.Log("Integer Skor Berkurang");
    }

    void UpdateTeksSkor()
    {
        textSkor.text = skor.ToString();
        Debug.Log("Integer Skor Diubah");
    }

    void ToggleKiriKanan()
    {
        if (squareMove13.isMoveRight)
        {
            squareMove13.isMoveRight = false;
        }
        else
        {
            squareMove13.isMoveRight = true;
        }
    }

    void MunculDariAtas()
    {

        //posisi kursor mouse
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //posisi titik paling atas layar 
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));

        //posisi kursor sumbu x, titik paling atas layar dan vector3 tempat jatuh
        Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikAtas.y, 0);

        //memunculkan objek bola jatuh di posisi tempat jatuh dengan rotasi quaternion.identity
        Instantiate(bolaJatuh, tempatJatuh, quaternion.identity);
    }
}
