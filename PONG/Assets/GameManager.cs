using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI LeftText;
    public TextMeshProUGUI RightText;
    public Button RestartButton;
    public ball GameBall;
    public int MaxScore = 1;

    public int LeftScore;
    public int RightScore;






    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public int IncrementScore(bool IsLeft)
    {
        if (!IsLeft)
        {
            LeftScore = LeftScore + 1;
            string Score = "";
            Score = Score + (LeftScore);
            LeftText.SetText(Score);
            if (LeftScore >= MaxScore)
            {
                RestartButton.gameObject.SetActive(true);
                GameBall.gameObject.SetActive(false);
            }
        }
        else
        {
            RightScore = RightScore + 1;
            string Score = "";
            Score = Score + (RightScore);
            RightText.SetText(Score);
            if (RightScore >= MaxScore)
            {
                RestartButton.gameObject.SetActive(true);
                GameBall.gameObject.SetActive(false);
            }
        }

        return 0;
    }

    public void RestartGame()
    {
        RestartButton.gameObject.SetActive(false);
        RightScore = 0;
        LeftScore = 0;
        LeftText.SetText("0");
        RightText.SetText("0");

    } 

}
