using UnityEngine;

public class Score : MonoBehaviour
{

    public PendeteksiInput objectPendeteksiInput;
    public int score;

    private void OnEnable()
    {
        //objectPendeteksiInput.inputEven += AddScore;    //listen C#
        //objectPendeteksiInput.inputEven.AddListenner(AddScore);   //listen unity lewat code bukan lewat inspector
    }


    public void AddScore()
    {
        score = score + 1;
    }

    private void OnDisable()
    {
        //objectPendeteksiInput.inputEven -= AddScore;      //unlisten C#
        //objectPendeteksiInput.inputEven.RemoveListenner(AddScore);       //unlisten unity lewat code bukan lewat inspector
    }
}
