using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class VolumeValueSlider : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Slider volumeValue;
    [SerializeField] TextMeshProUGUI volumeTXT;

    private void Update()
    {
        volumeTXT.text = AudioListener.volume.ToString();
    }

    public void SliderVolume()
    {
        AudioListener.volume = volumeValue.value;
    }
}
