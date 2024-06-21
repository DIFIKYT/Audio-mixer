using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {
        float minVolume = -80;
        float maxVolume = 0;
        float linearVolumemin = 0.0001f;
        float linearVolumeMax = 1f;

        _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, Mathf.Log10(Mathf.Clamp(volume, linearVolumemin, linearVolumeMax)) * (maxVolume - minVolume) / 4f + maxVolume);
    }
}