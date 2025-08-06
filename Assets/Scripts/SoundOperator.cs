using UnityEngine;
using UnityEngine.Audio;

public class SoundOperator : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    [SerializeField] private float _maxVolume;
    [SerializeField] private float _minVolume;
    private const float _multiplier = 20;

    public void ToggleAllSound(bool isEnabled)
    {
        if (isEnabled)
            _audioMixerGroup.audioMixer.SetFloat("MasterVolume", _maxVolume);
        else
            _audioMixerGroup.audioMixer.SetFloat("MasterVolume", _minVolume);
    }

    public void ChangeCommonVolume(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * _multiplier);
    }

    public void ChangeButtonsVolume(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat("ButtonsVolume", Mathf.Log10(volume) * _multiplier);
    }

    public void ChangeBackgroundVolume(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat("BackgroundMusicVolume", Mathf.Log10(volume) * _multiplier);
    }
}
