using UnityEngine;

public class Function : MonoBehaviour
{
    public int nyawa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(bilangan(2, 3, 4));
        MinumObat();
        MinumObat();
        Debug.Log(nyawa);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int bilangan(int x, int y, int z)  //ada pengembalian nilai
    {
        int hasil = x * y * z;
        return hasil;
    }

    public void MinumObat() //tidak mengembalikan nilai (tipe void)
    {
        Debug.Log("Pemain Minum Obat");
        Sembuhkan(30);
    }

    public void Sembuhkan(int TambahNyawa)
    {
        nyawa = nyawa + TambahNyawa;
    }
}
