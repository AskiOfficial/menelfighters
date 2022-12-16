using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class twoDplayer : MonoBehaviour
{
    [SerializeField] float movespead = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public void Start()
    { rb = GetComponent<Rigidbody2D>(); }
    public void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespead * Time.fixedDeltaTime);
    }
}
