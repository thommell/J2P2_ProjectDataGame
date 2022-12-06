using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MinigameScore : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public TimedEventButtonScript _tes;
    public int scoreInt;
    public int wonMinigames = 0;

    // Update is called once per frame
    private void Update()
    { 
        if(scoreInt >= 10)
        {
            wonMinigames++;
        }
            scoreText.text = scoreInt + "/10 \nbuttons";
    }
}
