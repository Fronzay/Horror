using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LightController : MonoBehaviour
{

    public RaycastController raycastController;

    [SerializeField] private bool light1off;
    [SerializeField] private bool light2off;
    [SerializeField] private bool light1on;
    [SerializeField] private bool light2on;
    [SerializeField] private bool TXTp;

    [SerializeField] public GameObject _light1off;
    [SerializeField] public GameObject _light2off;
    [SerializeField] public GameObject _light1on;
    [SerializeField] public GameObject _light2on;

    [SerializeField] GameObject text;

    [SerializeField] AudioSource chelk;


    private void Start()
    {
        raycastController = FindAnyObjectByType<RaycastController>();
    }

    private void Update()
    {
        if (Physics.Raycast(raycastController.ray, out raycastController.hitInfo, raycastController.distanceRay) && Input.GetKeyUp(KeyCode.E))
        {
            if (raycastController.hitInfo.collider.CompareTag("Light1off") && !light1off)
            {
                light1off = true;
                _light1off.SetActive(true);
                chelk.Play();
            }
            else if(raycastController.hitInfo.collider.CompareTag("Light1off") && light1off)
            {
                light1off = false;
                _light1off.SetActive(false);
                chelk.Play();
            }

            if (raycastController.hitInfo.collider.CompareTag("Light2off") && !light2off)
            {
                light2off = true;
                _light2off.SetActive(true);
                chelk.Play();
            }
            else if (raycastController.hitInfo.collider.CompareTag("Light2off") && light2off)
            {
                light2off = false;
                _light2off.SetActive(false);
                chelk.Play();
            }

            if (raycastController.hitInfo.collider.CompareTag("Light1on") && !light1on)
            {
                 light1on = true;
                _light1on.SetActive(true);
                chelk.Play();
            }
            else if (raycastController.hitInfo.collider.CompareTag("Light1on") && light1on)
            {
                light1on = false;
                _light1on.SetActive(false);
                chelk.Play();
            }

            if (raycastController.hitInfo.collider.CompareTag("Light2on") && !light2on)
            {
                light2on = true;
                _light2on.SetActive(true);
                chelk.Play();
            }
            else if (raycastController.hitInfo.collider.CompareTag("Light2on") && light2on)
            {
                light2on = false;
                _light2on.SetActive(false);
                chelk.Play();
            }
        }

        if ( !light1off && !light2off && light1on && light2on && !TXTp)
        {
            text.SetActive(true);
            StartCoroutine(nameof(_TXTp));
        }
        else if ( TXTp)
        {
            text.SetActive(false);  
        }

    }

    public IEnumerator _TXTp()
    {
        yield return new WaitForSeconds(3);
        TXTp = true;
    }


}
