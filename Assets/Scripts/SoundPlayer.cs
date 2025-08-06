using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;

    public void PlaySound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_audioClip);
    }
}
