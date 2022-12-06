using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTransition : MonoBehaviour
{
    [SerializeField] RectTransform squareL;
    [SerializeField] RectTransform squareR;


    public bool coroutineCheck = false;


    private void Awake()
    {
       
        StartCoroutine(OpenTransitionCor(0.5f));
    }
    public IEnumerator OpenTransitionCor(float time)
    {
        time *= Time.deltaTime; // makes code go realtime :slight_frown:
        if (coroutineCheck)
            yield break;
        coroutineCheck = true;

        Vector2 destination = squareL.position - new Vector3(Screen.width * 0.52f, 0);

        yield return new WaitForSeconds(0.5f); // FIX FOR UNITY LAG :DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD

        while (squareL.position.x > destination.x)
        {
            squareL.position = Vector2.Lerp(squareL.position, squareL.position - new Vector3(Screen.width * 0.5f, 0), time); // makes left square go >>>>>>>>>>>>>>>>>>
            squareR.position = Vector2.Lerp(squareR.position, squareR.position + new Vector3(Screen.width * 0.5f, 0), time); // makes right square go <<<<<<<<<<<<<<<<<<
            yield return new WaitForSeconds(time / 1.1f);
        }
        squareL.gameObject.SetActive(false); //  disables square
        squareR.gameObject.SetActive(false);
        yield break;
    }
}
