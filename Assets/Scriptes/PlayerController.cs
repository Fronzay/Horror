using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speedCharacter;
    [SerializeField] float gravity;
    [SerializeField] CharacterController characterController;

    Vector3 direction;
    Vector3 velocity;
   
    private void Update()
    {
        InputManager();
        Gravity();
    }

    public void LateUpdate()
    {
        CharacterMovement(direction);
    }

    public void InputManager()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        direction = transform.right * x + transform.forward * z;
    }

    public void CharacterMovement(Vector3 dir)
    {
        characterController.Move(dir * Time.deltaTime * speedCharacter);
    }

    public void Gravity()
    {
        velocity.y -= gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}
