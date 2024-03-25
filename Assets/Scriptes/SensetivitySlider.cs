using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SensetivitySlider : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Slider sensetivity;
    [SerializeField] TextMeshProUGUI sensetivityTXT;

    public MouseMovement mouseMovement;

    private void Update()
    {
        sensetivityTXT.text = sensetivity.value.ToString();
    }

    public void MouseSensetivity()
    {
        mouseMovement.mouseSensitivity = (int)sensetivity.value;
    }
}
