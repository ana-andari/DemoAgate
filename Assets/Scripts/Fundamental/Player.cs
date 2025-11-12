using UnityEngine;

[System.Serializable]  //untuk menjadikan variabel publik menjadi inputan
public class Player : MonoBehaviour
{

    public string Name; //jika public diubah jadi private, tidak bisa jadi inputan
    public int Level;
    public int Health;

    public Player(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public Player()
    {

    }


}
