using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody2D rb;
    private float movement = 0f;

    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.right * movement * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Ball"))
        {
            Debug.Log("Game OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
