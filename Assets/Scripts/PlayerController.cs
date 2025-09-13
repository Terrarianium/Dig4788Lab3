using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Variables
    public float movementSpeed = 5f;
    private Movement movement;
    private Vector2 currentMovement;

    // Create Input system and assign events
    void Start()
    {
        movement = new Movement();
        movement.Enable();

        movement.Gameplay.Movement.performed += ctx => currentMovement = ctx.ReadValue<Vector2>();
        movement.Gameplay.Movement.canceled += ctx => currentMovement = Vector2.zero;  
    }

    // Update 2D movement
    void FixedUpdate()
    {
        Vector3 movement2D = new Vector3(currentMovement.x, currentMovement.y, 0f);
        transform.position += movement2D * movementSpeed * Time.fixedDeltaTime;
    }
}
