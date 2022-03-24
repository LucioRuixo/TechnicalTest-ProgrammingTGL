using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] AudioSource _audioSource;

    public void PlayAudioClip(AudioClip audioClip) => _audioSource.PlayOneShot(audioClip);

    //TODO AudioManager
}