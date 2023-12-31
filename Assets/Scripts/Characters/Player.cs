using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    // Allows player body (Cube) to have physics, like gravity
    public Rigidbody player;

    // Sets a variable for how high the cube/player can jump
    public float JumpForce = 10f;

    private Vector3 moveDirection;

    void Start()
    {
        InputManager.Initialize(this);
        InputManager.GameMode();

        // Defines the Cube as variable player
        player = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * moveDirection;

        // If the button for "Jump" is pressed, run the following
        // Updated from "(Input.GetButtonDown("Jump"))
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Makes the cube do a jumping action
            player.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
        }
    }

    public void SetMovementDirection(Vector3 newDirection)
    {
        moveDirection = newDirection;
    }
}
