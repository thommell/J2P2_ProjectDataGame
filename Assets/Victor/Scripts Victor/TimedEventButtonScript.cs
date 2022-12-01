
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimedEventButtonScript : MonoBehaviour
{
    [SerializeField] Sprite unclickedButton;
    [SerializeField] Sprite clickedButton;
    [SerializeField] SpriteRenderer _sr;
    [SerializeField] MinigameScore _mgs;
    [SerializeField] FailCounter _fc;
    [SerializeField] Image _slider;

    private float lifetime = 5f;
    private float timer = 0f;
    private int clicksOnButton = 0;
    private int neededClicks = 10;
    private bool isPressed = false;
    private float pressTimer = 0;
    private float spriteDuration = 0.3f;

    public int buttonsCleared = 0;

    private Image _sliderimage;

    private void Start()
    {
        _mgs = FindObjectOfType<MinigameScore>();
        _fc = FindObjectOfType<FailCounter>();
        _sliderimage = transform.GetChild(0).GetChild(2).GetComponent<Image>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= lifetime)
        {
            Debug.Log("Noob");
            Destroy(gameObject);
            _fc.failInt++;
        }
        else if(clicksOnButton >= neededClicks)
        {
            Debug.Log("Pro");
            Destroy(gameObject);
            _mgs.scoreInt++;
        }

        if (isPressed)
        {
            _sr.sprite = clickedButton;
            pressTimer += Time.deltaTime;
        }
        if(pressTimer >= spriteDuration)
        {
            isPressed = false;
            pressTimer = 0;
            _sr.sprite = unclickedButton;
        }

    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
            {
            isPressed = true;
            clicksOnButton++;
            Debug.Log(clicksOnButton);
            _sliderimage.fillAmount = clicksOnButton/10f;
        }
    }
}
