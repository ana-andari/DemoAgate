using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteraksiUI : MonoBehaviour
{
    public SquareMove squareMove;
    public GameObject SquareUbahWarna;
    public TMP_Text KataBerubah;
    public TMP_Text NamaBerubah;
    public List<string> DaftarNama;
    public int IdNama = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NamaBerubah.text = DaftarNama[IdNama];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UbahKataKiri()
    {
        string kata = "kiri";
        KataBerubah.text = kata;
    }

    public void UbahKataKanan()
    {
        string kata = "kanan";
        KataBerubah.text = kata;
    }


    public void LanjutNama()
    {
        if (IdNama < DaftarNama.Count - 1)
        {
            IdNama++;
        }
        else
        {
            IdNama = 0;
        }
        NamaBerubah.text = DaftarNama[IdNama];
    }

    public void KembaliNama()
    {
        if (IdNama <= 0)
        {
            IdNama = DaftarNama.Count - 1;
        }
        else
        {
            IdNama--;
        }
        NamaBerubah.text = DaftarNama[IdNama];
    }


    public void UbahWarna(Color Warna)
    {
        SpriteRenderer sr = SquareUbahWarna.GetComponent<SpriteRenderer>();
        sr.color = Warna;
    }


    public void UbahWarnaAcak()
    {
        Color col = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        UbahWarna(col);
    }
    public void UbahWarnaMerah()
    {
        UbahWarna(Color.red);
    }
    public void UbahWarnaBiru()
    {
        UbahWarna(Color.blue);
    }
    public void UbahWarnaHijau()
    {
        UbahWarna(Color.green);
    }



    public void Mulai()
    {
        squareMove.isMove = true;
    }

    public void Berhenti()
    {
        squareMove.isMove = false;
    }

    public void GerakKanan()
    {
        squareMove.isMoveRight = true;
    }

    public void GerakKiri()
    {
        squareMove.isMoveRight = false;
    }
}
