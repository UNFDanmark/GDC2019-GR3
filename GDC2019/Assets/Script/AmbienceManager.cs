using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceManager : MonoBehaviour
{
    public AudioClip[] lyde;

    public AudioSource AmbSource;
    public float minBtwnSounds;
    public float maxBtwnSounds;

    float timeToNextSound;
    float timeSinceLastSound;
    // Start is called before the first frame update
    void Start()
    {
        timeToNextSound = Random.Range(minBtwnSounds, maxBtwnSounds);
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSound += Time.deltaTime;

        if(timeSinceLastSound >= timeToNextSound)
        {
            AmbSource.PlayOneShot(lyde[Random.Range(0, lyde.Length)]);
            timeToNextSound = Random.Range(minBtwnSounds, maxBtwnSounds);
            timeSinceLastSound = 0;
        }

    }
}
