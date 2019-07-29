using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeSpeeder : MonoBehaviour
{
    public AudioSource ThemeSource;
    public float gameLength = 60;
    public float timeLeft;
    public float maxPitch = 0.3f;
    public float pitchTilMusik;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = gameLength;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 1 && timeLeft > 0)
        {
            pitchTilMusik = (timeLeft + 0.3f);
            ThemeSource.pitch = pitchTilMusik;
        }
        else if(timeLeft <= 0)
        {
            ThemeSource.Stop();
        }
        else
        {
            pitchTilMusik = 1 + (maxPitch / gameLength) * (gameLength - timeLeft);
            ThemeSource.pitch = pitchTilMusik;
        }

    }
}
