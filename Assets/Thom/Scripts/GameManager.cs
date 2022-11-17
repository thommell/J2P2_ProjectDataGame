using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] TransitionElevator _ts;
    [SerializeField] OnClickMainMenu _ocmm;

    private bool coroutineCheck = false;

    public float openClose;

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
    }
    public IEnumerator CloseTransition(float timeWait)
    {
        openClose = 1;

        yield return StartCoroutine(_ts.ElevatorTransition(timeWait * Time.deltaTime));
        if (coroutineCheck)
            yield break;
        coroutineCheck = true;

        //yield return new WaitForSeconds(timeWait);

        switch (sceneNumber)
        {
            case 1:
               // SceneManager.LoadScene(1);
                StartCoroutine(OpenTransition(_ocmm.time));
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
        openClose = -1;

        yield return StartCoroutine(_ts.ElevatorTransition(timeWait * Time.deltaTime));
        if (coroutineCheck)
            yield break;
        coroutineCheck = true;

        //yield return new WaitForSeconds(timeWait);

        

        coroutineCheck = false;
    }
}
