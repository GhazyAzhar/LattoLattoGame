using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseDrag : MonoBehaviour
{
    // The Rigidbody2D component attached to this GameObject
    private Rigidbody2D rb;

    // A flag to track if the GameObject is currently being dragged
    private bool isDragging = false;
    private int kalahScreen;

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if the left mouse button is being held down
        if (Input.GetMouseButton(0))
        {
            // Get the mouse position in world space
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Check if the mouse is over the GameObject
            if (IsMouseOverGameObject(mousePosition))
            {
                // If the GameObject is not already being dragged, start dragging it
                if (!isDragging)
                {
                    isDragging = true;
                }
            }
        }
        // Check if the left mouse button was released
        else if (Input.GetMouseButtonUp(0))
        {
            // If the GameObject was being dragged, stop dragging it
            if (isDragging)
            {
                isDragging = false;
            }
        }

        // If the GameObject is being dragged, update its position
        if (isDragging)
        {
            // Get the mouse position in world space
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Set the position of the GameObject to the mouse position
            rb.position = mousePosition;
        }
    }

    // Returns true if the mouse position is over the GameObject, false otherwise
    private bool IsMouseOverGameObject(Vector2 mousePosition)
    {
        // Get the collider of the GameObject
        Collider2D collider = GetComponent<Collider2D>();

        // Check if the mouse position is inside the collider
        return collider.OverlapPoint(mousePosition);
    }
}