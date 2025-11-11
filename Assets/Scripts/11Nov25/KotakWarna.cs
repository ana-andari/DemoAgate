using UnityEngine;

public class KotakWarna : MonoBehaviour
{
    SpriteRenderer _spriterenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _spriterenderer = GetComponent<SpriteRenderer>();
        Color warna;
        ColorUtility.TryParseHtmlString("#A3F238", out warna);
        //_spriterenderer.color = Color.magenta;
    }
}
