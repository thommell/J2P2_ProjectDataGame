using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FailCounter : MonoBehaviour
{
    public int failInt;
    private Transform failCross;
    private GameObject failObject;
    [SerializeField] PlanetRandomizer _pr;

    private void Start()
    {
        _pr = FindObjectOfType<PlanetRandomizer>();
    }
    void Update()
    {
        for (int i = 0; i < failInt; i++)
        {
            failCross = this.gameObject.transform.GetChild(i);
            failObject = failCross.gameObject;
            Color color = failObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }
        if(failInt >= 3)
        {
            _pr.minigameFail = true;
            SceneManager.LoadScene(1);
        }
    }
}
