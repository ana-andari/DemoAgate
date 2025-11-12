using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AksiTombol : MonoBehaviour
{
    public Sprite assetGambar;   //Aset gambar yang akan dimasukkan ke objek unity
    public Image image;     // komponen onjek image dalam scene
    public TMP_Text objectText;     // komponen text dari objek text dalam scene
    public void Aksi()
    {
        // image.sprite = assetGambar;     // mengubah gambar
        // objectText.text = "Semangat";   // mengubah text
        // Debug.Log("Tombol Di Klik");

        SceneManager.LoadScene("Day 3 Pindah Scene");
    }
}
