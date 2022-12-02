using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] TransitionElevator _ts;

    public bool coroutineCheck = false;

    public int sceneNumber;

    private void Awake()
    {
        if (instance == null || instance == this)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
            DestroyImmediate(this.gameObject);

        _ts = FindObjectOfType<TransitionElevator>();
    }
    private void Start()
    {
        
    }
    public IEnumerator CloseTransition(float timeWait)
    {
        yield return StartCoroutine(_ts.ElevatorTransition(timeWait * Time.deltaTime));
        if (coroutineCheck)
            yield break;
        coroutineCheck = true;

        yield return new WaitForSeconds(0.25f);

        switch (sceneNumber)
        {
            case 1:
               SceneManager.LoadScene(1);
            yield return new WaitForSeconds(1f);
            StartCoroutine(OpenTransition(0.5f));
                break;
            case 2:
                SceneManager.LoadScene(2);
                break;
            case 3:
                SceneManager.LoadScene(3);
                break;
            default:
                break;
        }

        coroutineCheck = false;
    }
    public IEnumerator OpenTransition(float timeWait)
    {
        yield return StartCoroutine(_ts.ElevatorTransition(timeWait * Time.deltaTime));
        if (coroutineCheck)
            yield break;
        coroutineCheck = true;

        //yield return new WaitForSeconds(timeWait);
        coroutineCheck = false;
    }

}
