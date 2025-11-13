using System.Collections;

using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public GameObject SpawnObject;
    public bool SedangSpawn = true;


    void Start()
    {
        StartCoroutine(MunculkanObject());
    }

    IEnumerator MunculkanObject()
    {
        while (SedangSpawn == true)
        {
            Instantiate(SpawnObject, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity);
            yield return new WaitForSeconds(3); //perintah dijeda 5 detik
            Debug.Log("Perintah 2");
        }
    }
}
