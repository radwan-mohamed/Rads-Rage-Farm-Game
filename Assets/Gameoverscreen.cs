using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameoverscreen : MonoBehaviour

{
    public Text pointsText;


    public void Setup(double score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString()+ "POINTS";

    }
    public void restartbutton()
    {
        SceneManager.LoadScene("Prototype 2");
    }

















}
