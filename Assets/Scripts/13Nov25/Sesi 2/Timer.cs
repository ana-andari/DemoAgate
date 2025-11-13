using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float waktu;
    public float MaximumWaktu;

    public TMP_Text TextTimer;
    public bool WaktuBerjalan = true;

    public KeyCode StartCoroutineKey;
    public KeyCode StopCoroutineKey;
    public Coroutine HitungTimerCoroutine;

    public Image ProgresFill;   //reference progres fill



    // private void Start()
    // {
    //     StartCoroutine(HitungTimer());
    // }

    private void Update()
    {
        if (Input.GetKeyDown(StartCoroutineKey))
        {
            if (HitungTimerCoroutine == null)
            {
                HitungTimerCoroutine = StartCoroutine(HitungTimer());
            }

        }

        if (Input.GetKeyDown(StopCoroutineKey))
        {
            if (HitungTimerCoroutine != null)
            {
                StopCoroutine(HitungTimerCoroutine);
                HitungTimerCoroutine = null;
            }
        }
    }

    IEnumerator HitungTimer()
    {
        while (WaktuBerjalan == true)
        {
            waktu = waktu + 1;
            TextTimer.text = waktu.ToString();
            ProgresFill.fillAmount = waktu / MaximumWaktu;
            yield return new WaitForSeconds(1);
        }

    }
}
