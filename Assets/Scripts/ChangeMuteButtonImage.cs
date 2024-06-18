using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ChangeMuteButtonImage : MonoBehaviour
{
    [SerializeField] private Sprite _unMuteImage;
    [SerializeField] private Sprite _muteImage;
    [SerializeField] private Image _image;

    public event Action<bool> OnImageChanged;

    public void OnClick()
    {
        if (_image.sprite == _unMuteImage)
        {
            OnImageChanged?.Invoke(false);
            _image.sprite = _muteImage;
        }
        else
        {
            OnImageChanged?.Invoke(true);
            _image.sprite = _unMuteImage;
        }
    }
}