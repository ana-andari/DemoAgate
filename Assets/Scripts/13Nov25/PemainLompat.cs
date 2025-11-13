using UnityEngine;

public class PemainLompat : MonoBehaviour
{
    public bool dilantai;
    public float forceMultiplier = 3.0f; // variabel perhitungan daya lompat


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Lompat()
    {
        if (dilantai)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);
        }
        else
        {
            Debug.Log("Lagi Lompat");
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            dilantai = true;
            Debug.Log("dilantai");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            dilantai = true;
            Debug.Log("diudara");
        }
    }
}
