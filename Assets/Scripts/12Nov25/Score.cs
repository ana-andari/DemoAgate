using UnityEngine;

public class Score : MonoBehaviour
{

    public PendeteksiInput objectPendeteksiInput;
    public int score;

    private void OnEnable()
    {
        //objectPendeteksiInput.inputEven += AddScore;
    }


    public void AddScore()
    {
        score = score + 1;
    }

    private void OnDisable()
    {
        //objectPendeteksiInput.inputEven -= AddScore;
    }
}
