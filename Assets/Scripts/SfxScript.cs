using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxScript : MonoBehaviour
{
    [SerializeField] AudioClip powerUp;
    [SerializeField] AudioClip powerDown;
    AudioSource powerScale;
    // Start is called before the first frame update
    void Start()
    {
        powerScale = GetComponent<AudioSource>();
    }
    public void PlayPowerDownSound()
    {
        powerScale.PlayOneShot(powerDown);
    }
}
