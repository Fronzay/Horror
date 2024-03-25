using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    [SerializeField] Animator lever1;
    [SerializeField] Animator lever2;
    [SerializeField] Animator lever3;
    [SerializeField] Animator lever4;
    [SerializeField] Animator lever5;
    [SerializeField] Animator exitPodvalDoor;

    [SerializeField] public bool _lever1;
    [SerializeField] public bool _lever2;
    [SerializeField] public bool _lever3;
    [SerializeField] public bool _lever4;
    [SerializeField] public bool _lever5;
    [SerializeField] bool ray;

    public bool openExitP = false;

    [SerializeField] bool exitP = false;
    [SerializeField] public bool exitPDoorOpenClose = false;

    public float number;

    [SerializeField] public TextMeshProUGUI numberLever;

    public RaycastController raycastController;

    [SerializeField] AudioSource doorSound;
    [SerializeField] AudioSource lever;

    private void Start()
    {
        raycastController = FindAnyObjectByType<RaycastController>();
    }

    private void Update()
    {

        ray = Physics.Raycast(raycastController.ray, out raycastController.hitInfo, raycastController.distanceRay) && Input.GetKeyUp(KeyCode.E);

        if (!exitP)
        {
            numberLever.text = $"{number} / 5";
        }

        if (number >= 5)
        {
            exitP = true;
            exitPDoorOpenClose = true;

            if (exitP)
            {
                numberLever.text = "дверь открыта";
            }
        }

        if ( ray )
        {
         
            if ( raycastController.hitInfo.collider.CompareTag("lever1") && !_lever1)
            {
                number++;
                _lever1 = true;
                lever1.SetBool("Open", true);
                lever.Play();

            }

            if(raycastController.hitInfo.collider.CompareTag("lever2") && !_lever2)
            {
                number++;
                _lever2 = true;
                lever2.SetBool("Open", true);
                lever.Play();

            }

            if(raycastController.hitInfo.collider.CompareTag("lever3") && !_lever3)
            {
                number++;
                _lever3 = true;
                lever3.SetBool("Open", true);
                lever.Play();

            }

            if (raycastController.hitInfo.collider.CompareTag("lever4") && !_lever4)
            {
                number++;
                _lever4 = true;
                lever4.SetBool("Open", true);
                lever.Play();

            }

            if (raycastController.hitInfo.collider.CompareTag("lever5") && !_lever5)
            {
                number++;
                _lever5 = true;
                lever5.SetBool("Open", true);
                lever.Play();

            }

            if (raycastController.hitInfo.collider.CompareTag("ExPRoom") && !openExitP && exitPDoorOpenClose)
            {
                openExitP = true;
                exitPodvalDoor.SetBool("Exit", true);
                doorSound.Play();
            }

            if (_lever1 || _lever2 || _lever3 || _lever4 || _lever5)
            {
                numberLever.gameObject.SetActive(true);
            }

        }
    }   

}
