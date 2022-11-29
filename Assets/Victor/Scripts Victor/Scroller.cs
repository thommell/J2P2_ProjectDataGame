using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private int _x, _y;
    void Update()
    {
        if(sprite.transform.position.y <= -8.5)
        {
            sprite.transform.position = new Vector2(0, 8f);
        }
        sprite.transform.position = new Vector2(sprite.transform.position.x + (_x * Time.deltaTime), sprite.transform.position.y + (_y * Time.deltaTime));
    }
}
