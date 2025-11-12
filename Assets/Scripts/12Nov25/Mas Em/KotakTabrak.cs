using UnityEngine;

public class KotakTabrak : MonoBehaviour
{
    public ArahGerak arahGerak = ArahGerak.kanan;
    public float kecepatan = 5.0f;
    public InteraksiTombol interaksiTombol;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (arahGerak)
        {
            case ArahGerak.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;
            case ArahGerak.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            Debug.Log("Kotak Tabrak Dinding");
            if (arahGerak == ArahGerak.atas)
            {
                arahGerak = ArahGerak.bawah;
            }
            else if (arahGerak == ArahGerak.bawah)
            {
                arahGerak = ArahGerak.atas;
            }
            else if (arahGerak == ArahGerak.kiri)
            {
                arahGerak = ArahGerak.kanan;
            }
            else
            {
                arahGerak = ArahGerak.kiri;
            }
            interaksiTombol.skor++;
            TambahSkor();

        }
    }

    public void TambahSkor()
    {
        interaksiTombol.TextSkor.text = "skor : " + interaksiTombol.skor.ToString();
    }

    public enum ArahGerak
    {
        atas,
        bawah,
        kanan,
        kiri,

    }


}
