using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameScore : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public TimedEventButtonScript _tes;
    [SerializeField] PlanetRandomizer _pr;
    public int scoreInt;
    public int wonMinigames;

    private void Start()
    {
        _pr = FindObjectOfType<PlanetRandomizer>();
    }
    // Update is called once per frame
    private void Update()
    { 
            scoreText.text = scoreInt + "/10 \nbuttons";

            if(scoreInt >= 10)
            {
            _pr.makePlanet = true;
            SceneManager.LoadScene(1);
            }
    }
}
