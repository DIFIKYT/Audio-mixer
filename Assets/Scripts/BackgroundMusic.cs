using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BackgroundMusic : MonoBehaviour
{
    [SerializeField] private ChangeMuteButtonImage _changeMuteButtonImage;
    [SerializeField] private AudioSource _audioSource;

    private void OnEnable()
    {
        _changeMuteButtonImage.OnImageChanged += ChangeMusicState;
    }

    private void OnDisable()
    {
        _changeMuteButtonImage.OnImageChanged -= ChangeMusicState;
    }

    private void ChangeMusicState(bool musicOn)
    {
        if (musicOn)
            _audioSource.Play();
        else
            _audioSource.Stop();
    }
}