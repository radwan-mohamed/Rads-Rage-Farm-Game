using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WaveManger : MonoBehaviour
{   

    public Timer timeref;
    public MoveForward speedref1;
    public MoveForward speedref2;
    public MoveForward speedref3;

    public TextMeshProUGUI WaveText;

    // Start is called before the first frame update
    void Start()
    {
        speedref1.speed = 5;
        speedref2.speed = 5;
        speedref3.speed = 5;
        WaveText.text = "wave 0";
    }

    // Update is called once per frame
    void Update()
    {

        if (timeref.currentTime >= 20.00 && timeref.currentTime <= 20.05)
        {
            speedref1.speed = speedref1.speed + 3;
            speedref2.speed = speedref2.speed + 3;
            speedref3.speed = speedref3.speed + 3;
            WaveText.text = "wave 1";

        }
        if (timeref.currentTime >= 40.00 && timeref.currentTime <= 40.05)
        {
            speedref1.speed = speedref1.speed + 3;
            speedref2.speed = speedref2.speed + 3;
            speedref3.speed = speedref3.speed + 3;
            WaveText.text = "wave 2";
        }
        if (timeref.currentTime >= 60.00 && timeref.currentTime <= 60.05)
        {
            speedref1.speed = speedref1.speed + 3;
            speedref2.speed = speedref2.speed + 3;
            speedref3.speed = speedref3.speed + 3;
            WaveText.text = "wave 3";
        }
        if (timeref.currentTime >= 120.00 && timeref.currentTime <= 120.05)
        {
            speedref1.speed = speedref1.speed + 3;
            speedref2.speed = speedref2.speed + 3;
            speedref3.speed = speedref3.speed + 3;
            WaveText.text = "wave 4";
        }

    }
}
