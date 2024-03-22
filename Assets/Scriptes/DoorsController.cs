using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsController : MonoBehaviour
{
    public RaycastController raycastController;

    public bool openV = false;
    public bool openSklad = false;
    public bool openS = false;
    public bool openG = false;
    public bool openP = false;
    [SerializeField] Animator sRoom;
    [SerializeField] Animator vRoom;
    [SerializeField] Animator skladRoom;
    [SerializeField] Animator gRoom;
    [SerializeField] Animator podvalDoor;


    [SerializeField] GameObject keySpalny;
    [SerializeField] GameObject keyGostinnay;

    [SerializeField] AudioSource doorSound;

    public LightController lightController;

    private void Start()
    {
        raycastController = FindAnyObjectByType<RaycastController>();
        lightController = FindAnyObjectByType<LightController>();
    }

    private void Update()
    {
        if (Physics.Raycast(raycastController.ray, out raycastController.hitInfo, raycastController.distanceRay, raycastController.doors) && Input.GetKeyUp(KeyCode.E))

        {
            if (raycastController.hitInfo.collider.CompareTag("vRoom") && !openV)
            {
                openV = true;
                vRoom.SetBool("Open", true);
                doorSound.Play();
            }
            else if (raycastController.hitInfo.collider.CompareTag("vRoom") && openV)
            {
                openV = false;
                vRoom.SetBool("Open", false);
                doorSound.Play();
            }


            if (raycastController.hitInfo.collider.CompareTag("sRoom") && keySpalny.activeSelf)
            {
                openS = true;
                sRoom.SetBool("Open", true);
                keySpalny.SetActive(false);
                doorSound.Play();
            }

            if (raycastController.hitInfo.collider.CompareTag("skladRoom") && !openSklad)
            {
                openSklad = true;
                skladRoom.SetBool("Open", true);
                doorSound.Play();
            }
            else if (raycastController.hitInfo.collider.CompareTag("skladRoom") && openSklad)
            {
                openSklad = false;
                skladRoom.SetBool("Open", false);
                doorSound.Play();
            }

            if (raycastController.hitInfo.collider.CompareTag("gRoom") && !openG && keyGostinnay.activeSelf)
            {
                keyGostinnay.SetActive(false);
                openG = true;
                gRoom.SetBool("Open", true);
                doorSound.Play();
            }

            if (raycastController.hitInfo.collider.CompareTag("pRoom") && !openP && !lightController._light1off.activeSelf && !lightController._light2off.activeSelf && lightController._light1on.activeSelf && lightController._light2on.activeSelf)
            {
                openP = true;
                podvalDoor.SetBool("Open", true);
                doorSound.Play();
            }
            else if (raycastController.hitInfo.collider.CompareTag("pRoom") && openP && !lightController._light1off.activeSelf && !lightController._light2off.activeSelf && lightController._light1on.activeSelf && lightController._light2on.activeSelf)
            {
                openP = false;
                podvalDoor.SetBool("Open", false);
                doorSound.Play();
            }

        }
    }

    
}
