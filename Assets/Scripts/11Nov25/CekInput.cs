using UnityEngine;

public class CekInput : MonoBehaviour
{
    public GameObject MunculHilang;
    public GameObject _untukSpawn;
    public GameObject _targetHancur;
    public GameObject _kotakBerwarna;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tombol Spasi ditekan");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Tombol O ditekan. objek muncul");
            MunculHilang.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tombol P ditekan. objek hilang");
            MunculHilang.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombol Enter Ditekan");
            Instantiate(_untukSpawn, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.Euler(0, 0, 0)); //koordinat dan rotasi
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            GameObject hancurkan = GameObject.FindGameObjectWithTag("Sasaran"); //menghancurkan objek dengan tag Sasaran
            Debug.Log("Tombol H Ditekan");
            Destroy(_targetHancur);
            Destroy(hancurkan);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SpriteRenderer _localSpriteRenderer = _kotakBerwarna.GetComponent<SpriteRenderer>();
            Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            _localSpriteRenderer.color = warnaAcak;
        }
    }
}
