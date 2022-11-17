using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionElevator : MonoBehaviour
{
    [SerializeField] RectTransform squareL;
    [SerializeField] RectTransform squareR;

    // animate the game object from -1 to +1 and back
    //public float minimum = 0f;
    // public float maximum = 1000F;

    // starting value for the Lerp

    public void TransitionStart(float time)
    {
        StartCoroutine(Move(time * Time.deltaTime));
    }

    public IEnumerator Move(float time)
    {
        Vector2 destination = squareL.position + new Vector3(Screen.width * 0.52f, 0);

        while (squareL.position.x < destination.x)
        {
            squareL.position = Vector2.Lerp(squareL.position, squareL.position + new Vector3(Screen.width * 0.5f, 0), time);
            squareR.position = Vector2.Lerp(squareR.position, squareR.position - new Vector3(Screen.width * 0.5f, 0), time);
            yield return new WaitForSeconds(time / 2);
        }

        yield break;
    }
}
