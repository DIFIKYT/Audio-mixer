using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ChangeMuteButtonImage : MonoBehaviour
{
    [SerializeField] private Sprite _unMuteImage;
    [SerializeField] private Sprite _muteImage;
    [SerializeField] private Image _image;
    [SerializeField] private Toggle _toggle;

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(ChangeImage);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(ChangeImage);
    }

    public void ChangeImage(bool enabled)
    {
        if (enabled)
            _image.sprite = _unMuteImage;
        else
            _image.sprite = _muteImage;
    }
}