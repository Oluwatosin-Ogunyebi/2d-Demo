using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    AIPath aiPath;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        aiPath = GetComponent<AIPath>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical);
        rb.velocity = movement.normalized * speed;

        if (Input.GetMouseButtonUp(0) && !PaperCurl.isDragging)
        {
                aiPath.destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);           
        }
    }


}
