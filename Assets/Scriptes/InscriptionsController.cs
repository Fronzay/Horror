using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using static UnityEditor.Recorder.OutputPath;

public class InscriptionsController : MonoBehaviour
{
    public RaycastController raycastController;

    [SerializeField] TextMeshProUGUI inscriptions;
    [SerializeField] GameObject keySpalny;

    public DoorsController doorsController;
    public LightController lightController;

    [SerializeField] public bool lighting = false;

    private void Start()
    {
        raycastController = FindAnyObjectByType<RaycastController>();
        doorsController = FindAnyObjectByType<DoorsController>();
        lightController = FindAnyObjectByType<LightController>();
    }

    private void Update()
    {
        if (Physics.Raycast(raycastController.ray, out raycastController.hitInfo, raycastController.distanceRay))
        {

            if ((raycastController.hitInfo.collider.gameObject.CompareTag("vRoom")))
            {
                inscriptions.text = "ванная комната";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("skladRoom"))
            {
                inscriptions.text = "Склад";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("gRoom"))
            {
                inscriptions.text = "Гостинная";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("sRoom"))
            {
                inscriptions.text = "Спальня";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("keyS"))
            {
                inscriptions.text = "Ключ от спальни";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("keyG"))
            {
                inscriptions.text = "Ключ от гостинной";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("Ventel"))
            {
                inscriptions.text = "Вентель";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("Light1off") || raycastController.hitInfo.collider.gameObject.CompareTag("Light2off") || raycastController.hitInfo.collider.gameObject.CompareTag("Light1on") || raycastController.hitInfo.collider.gameObject.CompareTag("Light2on"))
            {
                inscriptions.text = "Лампа вкл/выкл";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("pRoom"))
            {
                inscriptions.text = "Подвал";
            }
            else
            {
                inscriptions.text = string.Empty;
            }

            if (Physics.Raycast(raycastController.ray, out raycastController.hitInfo, raycastController.distanceRay) && !keySpalny.activeSelf && Input.GetKey(KeyCode.E) && doorsController.openS == false)
            {
                if (raycastController.hitInfo.collider.gameObject.CompareTag("sRoom"))
                {
                    inscriptions.text = "Нужен ключ";
                }

                if (raycastController.hitInfo.collider.gameObject.CompareTag("gRoom"))
                {
                    inscriptions.text = "Нужен ключ";
                }

            }  
            
        }

        if (!lighting && !lightController._light1off.activeSelf && !lightController._light2off.activeSelf && lightController._light1on.activeSelf && lightController._light2on.activeSelf)
        {
           
        }
    }

    private void NullTXT()
    {
        inscriptions.text = string.Empty;
    }
}
