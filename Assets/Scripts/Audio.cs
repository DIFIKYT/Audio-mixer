using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    [SerializeField] private Toggle _toggle;

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(ToggleMusic);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(ToggleMusic);
    }

    public void ToggleMusic(bool enabled)
    {
        int minVolume = -80;
        int maxVolume = 0;

        if (enabled)
            _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, maxVolume);
        else
            _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, minVolume);
    }
}