using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;

    private int points;

    public int Points
    {
        get
        {
            return points;
        }

        set
        {
            points += value;

            UpdatePointsText();
        }
    }

    void MostrarPontos()
    {
        Debug.Log("Pontos : " + points);
    }

    void UpdatePointsText()
    {
        ScoreText.text = "Ponts: " + points.ToString();
    }
}
