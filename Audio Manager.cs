using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public int minAudioIndex = 1; // Set the minimum index of your audio files.
    public int maxAudioIndex = 50; // Set the maximum index of your audio files.

    private AudioSource audioSource;
    private string audioPath = "Audio/"; // This should be the path to your audio files.

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayRandomSound()
    {
        int randomIndex = Random.Range(minAudioIndex, maxAudioIndex + 1); // Generate a random index.

        // Load and play the corresponding audio clip.
        AudioClip audioClip = Resources.Load<AudioClip>(audioPath + randomIndex.ToString());
        if (audioClip != null)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Audio clip not found for index " + randomIndex);
        }
    }

}
