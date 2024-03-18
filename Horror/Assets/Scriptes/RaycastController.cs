using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
     [SerializeField] Transform rayStart;
     [SerializeField] LayerMask layerMask;
     [SerializeField] float distanceRay;
     [SerializeField] Ray ray;
     [SerializeField] RaycastHit hitInfo;
     [SerializeField] string itog;
     [SerializeField] GameObject lazers;

    private void Update()
    {
        ray = new Ray(rayStart.position, rayStart.forward);
       

        if (Physics.Raycast(ray, out hitInfo, distanceRay, layerMask) && Input.GetMouseButtonDown(0))
        {
            
            if (hitInfo.collider.gameObject.CompareTag("1"))
            {
                codePanel.text += '1';
            }
            if (hitInfo.collider.gameObject.CompareTag("2"))
            {
                codePanel.text += '2';
            }

            if (hitInfo.collider.gameObject.CompareTag("3"))
            {
                codePanel.text += '3';
            }

            if (hitInfo.collider.gameObject.CompareTag("4"))
            {
                codePanel.text += '4';
            }

            if (hitInfo.collider.gameObject.CompareTag("5"))
            {
                codePanel.text += '5';
            }

            if (hitInfo.collider.gameObject.CompareTag("6"))
            {
                codePanel.text += '6';
            }

            if (hitInfo.collider.gameObject.CompareTag("7"))
            {
                codePanel.text += '7';
            }
            if (hitInfo.collider.gameObject.CompareTag("8"))
            {
                codePanel.text += '8';
            }
            if (hitInfo.collider.gameObject.CompareTag("9"))
            {
                codePanel.text += '9';
            }

            if ( codePanel.text.Length >= 4 && codePanel.text != itog)
            {
                Invoke(nameof(NullNumber), 1);
            }

            if (codePanel.text.Length >= 4 && codePanel.text == itog)
            {
                lazers.SetActive(false);
            }

            codePanel.text = codePanel.text.Substring(0, 4);
            
        }
    }

    public void NullNumber()
    {
        codePanel.text = null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(rayStart.position, rayStart.forward * distanceRay);
    }


    //��������� ���������

    [SerializeField] float num1;
    [SerializeField] float num2;
    [SerializeField] float num3;
    [SerializeField] float num4;
    public char number;

    [SerializeField] string _num1;
    [SerializeField] string _num2;
    [SerializeField] string _num3;
    [SerializeField] string _num4;

    public TextMeshProUGUI codePanel;
    //��� ��� �����
    [SerializeField] TextMeshProUGUI _num1_;
    [SerializeField] TextMeshProUGUI _num2_;
    [SerializeField] TextMeshProUGUI _num3_;
    [SerializeField] TextMeshProUGUI _num4_;

    [SerializeField] char nuM1;
    [SerializeField] char nuM2;
    [SerializeField] char nuM3;
    [SerializeField] char nuM4;


    private void Start()
    {
        num1 = Random.Range(1, 9);
        num2 = Random.Range(1, 9);
        num3 = Random.Range(1, 9);
        num4 = Random.Range(1, 9);

        _num1 = num1.ToString();
        _num2 = num2.ToString();
        _num3 = num3.ToString();
        _num4 = num4.ToString();

        _num1_.text = _num1;
        _num2_.text = _num2;
        _num3_.text = _num3;
        _num4_.text = _num4;

        itog = _num1 + _num2 + _num3 + _num4;

    }
}
