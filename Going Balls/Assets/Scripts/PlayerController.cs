using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private float normalSpeed;
    public float boostedSpeed;
    public float speedCoolDown;
    public float jumpForce = 300f;
 

    private Rigidbody rb;
    Vector2 _movement;

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        normalSpeed = speed;
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

    }

    public void OnFire(InputValue value) => rb.AddForce(Vector2.up * jumpForce);

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "next")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.tag =="SpeedBoost")
        {
            speed = boostedSpeed;
            StartCoroutine("SpeedDuration");
        }
    }
    IEnumerator SpeedDuration()
    {
        yield return new WaitForSeconds(speedCoolDown);
        speed = normalSpeed;
    }

}