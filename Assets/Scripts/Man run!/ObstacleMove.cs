using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float speed = 10f;
    public PlayerController playerOver;
    // Start is called before the first frame update
    void Start()
    {
        playerOver = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15 && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
        if (!playerOver.gameOver && playerOver.inCenter)
            transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
