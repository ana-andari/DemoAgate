using UnityEngine;

public class Contoh3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int age = 17;
        int money = 50000;
        if (age > 18 && money > 100000)
        {
            Debug.Log("Anda boleh Masuk");
        }
        else
        {
            Debug.Log("Anda Tidak boleh Masuk");
        }

        int Id = 2;
        switch (Id)
        {
            case 1:
                Debug.Log("Basic Sword");
                break;
            case 2:
                Debug.Log("Electric Bow");
                break;
            default:
                Debug.Log("Fire Spell");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
