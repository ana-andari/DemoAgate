using UnityEngine;

public class ClassPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = new Player();
        player.Name = "Ida";
        player.Level = 18;
        player.Health = 100;

        Player player1 = new Player();
        player1.Name = "Andi";
        player1.Level = 20;
        player1.Health = 100;

        Debug.Log(player.Name);
        Debug.Log(player.Level);
        Debug.Log(player.Health);

        Debug.Log(player1.Name);
        Debug.Log(player1.Level);
        Debug.Log(player1.Health);

        //Menggunakan constructor
        Player player2 = new Player("ana", 2, 200);

        Debug.Log(player2.Name);
        Debug.Log(player2.Level);
        Debug.Log(player2.Health);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
