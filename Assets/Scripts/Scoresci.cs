using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoresci : MonoBehaviour
{
    public double score = 0;
    public double bestscore ;
    public detectcollisions flago;
    public TextMeshProUGUI scoreText;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score=score+flago.flag;

        scoreText.text = "score:" + score.ToString();
        if (score > bestscore)
        {
            bestscore = score;
        }
    }
}
    
