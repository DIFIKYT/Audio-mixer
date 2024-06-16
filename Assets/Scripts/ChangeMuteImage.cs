using UnityEngine;
using UnityEngine.UI;

public class ChangeMuteImage : MonoBehaviour
{
    [SerializeField] private Sprite _unMuteImage;
    [SerializeField] private Sprite _muteImage;

    public void OnClick()
    {
        if (TryGetComponent<Image>(out Image image))
        {
            if (image.sprite == _unMuteImage)
                image.sprite = _muteImage;
            else
                image.sprite = _unMuteImage;
        }
    }
}