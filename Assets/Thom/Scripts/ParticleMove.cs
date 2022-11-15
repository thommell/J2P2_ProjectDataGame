using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMove : MonoBehaviour
{
    [SerializeField] float particleSpeed = 5f;
    public Transform target;
    void Update()
    {
        target.transform.Translate(Vector3.forward * Time.deltaTime * particleSpeed * 1);
        target.transform.Translate(Vector3.left * Time.deltaTime * particleSpeed * 1);
    }


}
