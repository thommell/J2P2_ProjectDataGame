using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MinigameScore : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public TimedEventButtonScript _tes;
    public int scoreInt;

    // Update is called once per frame
    private void Update()
    { 
            scoreText.text = scoreInt + "/10 \nbuttons";
    }
}
