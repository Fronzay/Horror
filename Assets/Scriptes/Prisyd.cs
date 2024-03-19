using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prisyd : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] bool isBarrier;
    [SerializeField] float rayDistance;
    [SerializeField] Transform startRay;


    Ray ray;
    RaycastHit hit;

    [SerializeField] PlayerController playerController;

    private void FixedUpdate()
    {
        ray = new Ray(startRay.position, startRay.up);
        isBarrier = Physics.Raycast(ray, out hit, rayDistance);
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerController.speedCharacter = 2;
            transform.localPosition = new Vector3(0, 0.100f, 0);
            controller.height = 1.16f;
            controller.center = new Vector3(0, -0.44f, 0);
        }
        else
        {
            if (!isBarrier)
            {
                transform.localPosition = new Vector3(0, 0.574f, 0);
                controller.height = 2;
                controller.center = new Vector3(0, 0, 0);
                playerController.speedCharacter = 4;
            }
        }
    }
}
