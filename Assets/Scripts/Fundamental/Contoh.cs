using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int Number1 = 10;
    int Number2 = 7;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello word");
        int Number3 = Number1;
        Number1 = Number2;
        Number2 = Number3;
        Debug.Log(Number1);
        Debug.Log(Number2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
