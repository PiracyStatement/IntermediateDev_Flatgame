using UnityEngine;
using System;

public class PlayerWalk : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;

    private AudioSource[] sounds;

    public float moveInputH;
    public float speed;
    public bool isFacingRight = false;
    public bool isPlanting = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sounds = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlanting)
        {
            return;
        }

        moveInputH = Input.GetAxis("Horizontal"); //0 when neither left nor right are pressed. -1 left, 1 right

        FlipSprite();

        if ((Input.GetKeyDown(KeyCode.LeftArrow)) || (Input.GetKeyDown(KeyCode.RightArrow)))
        {
            sounds[1].Play();
        }

        if ((Input.GetKeyUp(KeyCode.LeftArrow)) || (Input.GetKeyUp(KeyCode.RightArrow)))
        {
            sounds[1].Pause();
        }

        rb.linearVelocity = new Vector2(moveInputH * speed, rb.linearVelocity.y);
        animator.SetFloat("xVelocity", Math.Abs(rb.linearVelocity.x));

        if (moveInputH != 0 )
        {
            PlayerVariables.isWalking = true;
        }
        else
        {
            PlayerVariables.isWalking = false;
        }
    }

    void FlipSprite()
    {
        if(((isFacingRight == true) && (moveInputH > 0f)) || ((isFacingRight == false) && (moveInputH < 0f)))
        {
            isFacingRight = !isFacingRight;
            Vector3 scale = transform.localScale; //make temp vector and copy our current transform into it
            scale.x *= -1f; //flip object horizontally
            transform.localScale = scale;
        }
    }

    public void MoveTo(float x)
    {
        Vector3 loc = transform.localPosition;
        loc.x = x;
        transform.localPosition = loc;
    }

    public void PlantBomb()
    {
        moveInputH = 0;
        rb.linearVelocity = new Vector2(0, 0);
        animator.SetFloat("xVelocity", 0);
        sounds[1].Pause();
        isPlanting = true;
    }
}
