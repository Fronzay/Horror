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
    public LeverController leverController;

    [SerializeField] public bool lighting = false;

    private void Start()
    {
        raycastController = FindAnyObjectByType<RaycastController>();
        doorsController = FindAnyObjectByType<DoorsController>();
        lightController = FindAnyObjectByType<LightController>();
        leverController = FindAnyObjectByType<LeverController>();
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
                inscriptions.text = "склад";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("gRoom"))
            {
                inscriptions.text = "гостинная";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("sRoom"))
            {
                inscriptions.text = "спальня";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("keyS"))
            {
                inscriptions.text = "ключ от спальни";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("keyG"))
            {
                inscriptions.text = "ключ от гостинной";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("Ventel"))
            {
                inscriptions.text = "вентель";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("Light1off") || raycastController.hitInfo.collider.gameObject.CompareTag("Light2off") || raycastController.hitInfo.collider.gameObject.CompareTag("Light1on") || raycastController.hitInfo.collider.gameObject.CompareTag("Light2on"))
            {
                inscriptions.text = "лампа вкл/выкл";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("pRoom"))
            {
                inscriptions.text = "подвал";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("ExPRoom"))
            {
                inscriptions.text = "выход из подвала";
            }
            else if (raycastController.hitInfo.collider.gameObject.CompareTag("lever1") || raycastController.hitInfo.collider.gameObject.CompareTag("lever2") || raycastController.hitInfo.collider.gameObject.CompareTag("lever3") || raycastController.hitInfo.collider.gameObject.CompareTag("lever4") || raycastController.hitInfo.collider.gameObject.CompareTag("lever5"))
            {
                inscriptions.text = "рычаг";
            }
            else
            {
                inscriptions.text = string.Empty;
            }



            if (Physics.Raycast(raycastController.ray, out raycastController.hitInfo, raycastController.distanceRay) && !keySpalny.activeSelf && Input.GetKey(KeyCode.E) && doorsController.openS == false)
            {
                if (raycastController.hitInfo.collider.gameObject.CompareTag("sRoom"))
                {
                    inscriptions.text = "нужен ключ";
                }

                if (raycastController.hitInfo.collider.gameObject.CompareTag("gRoom"))
                {
                    inscriptions.text = "нужен ключ";
                }

            }
                
            if (Physics.Raycast(raycastController.ray, out raycastController.hitInfo, raycastController.distanceRay) && Input.GetKey(KeyCode.E)) {

                if (raycastController.hitInfo.collider.CompareTag("ExPRoom") && leverController.number < 5)
                {
                    inscriptions.text = "дверь заперта";

                }
                else
                {
                    
                }
            }
        }           

    }
}
