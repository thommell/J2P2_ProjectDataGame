using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClips;
    [SerializeField] AudioSource _as;
    // Start is called before the first frame update
    public void PlayRandomAudio()
    {
        _as.clip = audioClips[Random.Range(0, audioClips.Length)];
        _as.Play();
    }
}
