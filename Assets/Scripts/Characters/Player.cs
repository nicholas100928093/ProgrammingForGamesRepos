using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    // Allows player body (Cube) to have physics, like gravity
    public Rigidbody player;

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
        if (Input.GetButtonDown("Jump"))
        {
            // Makes the cube do a jumping action
            player.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }

    public void SetMovementDirection(Vector3 newDirection)
    {
        moveDirection = newDirection;
    }
}
