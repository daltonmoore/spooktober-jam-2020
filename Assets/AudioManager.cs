using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField]
    AudioClip islandTheme, townTheme;
    bool islandThemeIsPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = islandTheme;
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            if (islandThemeIsPlaying)
            {
                audioSource.clip = townTheme;
                islandThemeIsPlaying = false;
            }
            else
            {
                audioSource.clip = islandTheme;
                islandThemeIsPlaying = true;
            }

            audioSource.Play();
        }
    }
}
