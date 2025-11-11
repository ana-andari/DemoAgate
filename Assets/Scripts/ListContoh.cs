using System.Collections.Generic;
using Unity.Android.Gradle;
using UnityEngine;

public class ListContoh : MonoBehaviour
{
    [SerializeField]

    List<Player> ListPlayer = new List<Player>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = ListPlayer.Find(element => element.Level > 15);
        Debug.Log(player.Name);
        //bool isExsist = ListPlayer.Exists(element => element == "Fadhil");
        //Debug.Log(isExsist);
        // ListPlayer.Insert(1, "Anton");
        ListPlayer.RemoveAt(0);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
