using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement;
    public GameObject gameoverText;
    public GameObject restart;

    private Rigidbody rb;
    private float movementX;
    private float movementY;



    void Start()
    {
        gameoverText.SetActive(false);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            gameoverText.SetActive(true);
        }

    }

    public void Restart()
    {
        gameoverText.SetActive(false);
        FindObjectOfType<GameManager>().EndGame();

    }
}
