using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedEventButtonScript : MonoBehaviour
{
    [SerializeField] Sprite unclickedButton;
    [SerializeField] Sprite clickedButton;
    [SerializeField] SpriteRenderer _sr;

    private float lifetime = 5f;
    private float timer = 0f;
    private int clicksOnButton = 0;
    private int neededClicks = 10;
    private bool isPressed = false;
    private float pressTimer = 0;
    private float spriteDuration = 0.3f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= lifetime)
        {
            Debug.Log("Noob");
            Destroy(gameObject);
        }
        else if(clicksOnButton >= neededClicks)
        {
            Debug.Log("Pro");
            Destroy(gameObject);
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
        }
    }
}
