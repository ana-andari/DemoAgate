using TMPro;
using UnityEngine;

public class InteraksiTombol : MonoBehaviour
{
    public KotakTabrak kotakTabrak;
    public int skor;
    public TMP_Text TextSkor;
    public int nyawa;
    public TMP_Text TextNyawa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nyawa = 3;
        kotakTabrak.KurangNyawa();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GerakAtas()
    {
        kotakTabrak.arahGerak = KotakTabrak.ArahGerak.atas;
    }

    public void GerakBawah()
    {
        kotakTabrak.arahGerak = KotakTabrak.ArahGerak.bawah;
    }

    public void GerakKanan()
    {
        kotakTabrak.arahGerak = KotakTabrak.ArahGerak.kanan;
    }

    public void GerakKiri()
    {
        kotakTabrak.arahGerak = KotakTabrak.ArahGerak.kiri;
    }
}
