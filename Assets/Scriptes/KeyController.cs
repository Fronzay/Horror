using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] GameObject keySpalny;
    [SerializeField] GameObject keySpalnyDel;
    [SerializeField] GameObject keyGostinnay;
    [SerializeField] GameObject keyGostinnayDel;
    [SerializeField] GameObject shisha;
    [SerializeField] Animator ventelAnim;

    [SerializeField] AudioSource keyPodbor; 

    public RaycastController raycastController;

    private void Start()
    {
        raycastController = FindAnyObjectByType<RaycastController>();
        keySpalnyDel.name = "KeyS";
    }

    private void Update()
    {
        if ( Physics.Raycast(raycastController.ray, out raycastController.hitInfo, raycastController.distanceRay) && Input.GetKey(KeyCode.E)) 
        {
            if (raycastController.hitInfo.collider.CompareTag("keyS"))
            {
                keyPodbor.Play();
                Destroy(keySpalnyDel);
                keySpalny.SetActive(true);
            }

            if (raycastController.hitInfo.collider.CompareTag("keyG"))
            {
                keyPodbor.Play();
                Destroy(keyGostinnayDel);
                keyGostinnay.SetActive(true);
            }

            if (raycastController.hitInfo.collider.CompareTag("Ventel"))
            {
                shisha.SetActive(false);
                ventelAnim.SetBool("Yes", true);

            }
        }
    }
}
