using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rig;
    private Animator anim;
    public ParticleSystem explosion;
    public ParticleSystem dirt;
    private AudioSource Audio;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private bool jump;
    public float gravity = 1f;
    public bool isOnGround = true;
    public bool gameOver = false;
    public bool inCenter = false;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        Physics.gravity *= gravity;
        anim = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 0 && !gameOver)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 10);
        }
        else
            inCenter = true;
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround &&!gameOver)
        {
            rig.AddForce(Vector3.up * 1000, ForceMode.Impulse);
            isOnGround = false;
            anim.SetTrigger("Jump_trig");
            dirt.Stop();
            Audio.PlayOneShot(jumpSound,1.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirt.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            anim.SetInteger("DeathType_int",1);
            anim.SetBool("Death_b", true);
            explosion.Play();
            dirt.Stop();
            Audio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
