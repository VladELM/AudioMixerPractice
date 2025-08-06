using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof(Slider))]
public class SliderBehaviour : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    [SerializeField] private string _volumeName;
    
    private const float MinVolume = -80f;
    private const float Multiplier = 20;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeSoundVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeSoundVolume);
    }

    public void ChangeSoundVolume(float volume)
    {
        if (volume == 0)
            _audioMixerGroup.audioMixer.SetFloat(_volumeName, MinVolume);
        else
            _audioMixerGroup.audioMixer.SetFloat(_volumeName, Mathf.Log10(volume) * Multiplier);
    }
}
