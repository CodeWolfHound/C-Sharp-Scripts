using NUnit.Framework.Internal;
using System;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4f;
    private Rigidbody2D body;
    public AudioSource sound;
    private Vector2 direction;
    [SerializeField] private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        sound.mute = true;
        sound.Play();
        sound.Pause();
        sound.mute = false;
    }
    void Update()
    {

        
        //Run on condition 
        if (direction != Vector2.zero)
        {
            animator.SetBool("isWalking", true);
            SoundOn();
        }
        else
        {
            animator.SetBool("isWalking", false);
            SoundOff();
        }

    }
    //Calls a fixed time by default every 0.0.2 seconds = 50 seconds per second.
    private void FixedUpdate()
    {
        PlayerMovment();
    }
    //Plays sound file
    public void SoundOn()
    {

        if (!sound.isPlaying)
        {

            sound.UnPause();
        }

    }
    //Stop sound file
    public void SoundOff()
    {

        if (sound.isPlaying)
        {

            sound.Pause();
        }

    }
    void OnTriggerEnter2D(Collider2D item)
    {
        //checks if player colider touches another colider with tag
        if (item.CompareTag("Interactable"))
        {
            Debug.Log("I touched something");

        }
    }
    //Stops player moving
    private void PlayerMovment()
    {
        // Grabs x and y positions to have 
        float xPostion = Input.GetAxis("Horizontal");
        float yPostion = Input.GetAxis("Vertical");
        // passing the x and y positions into the animator params
        animator.SetFloat("xVelocity",xPostion);
        animator.SetFloat("yVelocity", yPostion);
        //variable with x and y positions
        direction = new Vector2(xPostion, yPostion).normalized;

        body.linearVelocity = direction * speed;

    }
    public void StopMoving()
    {
        speed = 0;
        sound.volume = 0;
    }
    //Allows player moving
    public void AllowMoving()
    {
        speed = 4;
        sound.volume = 1;
    }
}   
