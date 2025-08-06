using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Toggle))]
public class ToggleBehaviour : MonoBehaviour
{
    [SerializeField] private AudioListener _audioListener;

    private Toggle _toggle;

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();
    }

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(ToggleAllSound);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(ToggleAllSound);
    }

    public void ToggleAllSound(bool isEnabled)
    {
        _audioListener.enabled = isEnabled;
    }
}
