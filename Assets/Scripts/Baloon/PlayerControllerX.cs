using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver =false;

    public float floatForce;
    private float gravityModifier = 1f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip limitSound;
    bool lowEnough = true;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 13.5f)
            lowEnough = false;
        else
            lowEnough = true;
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver )
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
        if (transform.position.y<1 && !gameOver)
        {
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
            playerRb.AddForce(Vector3.up * floatForce * 0.1f,ForceMode.Impulse);
            playerAudio.PlayOneShot(limitSound, 1.0f);
        }
        if (transform.position.y > 14 && !gameOver )
        {
            transform.position = new Vector3(transform.position.x, 14, transform.position.z);
            playerRb.AddForce(Vector3.down * floatForce * 0.15f, ForceMode.Impulse);
            playerAudio.PlayOneShot(limitSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }


    }

}
