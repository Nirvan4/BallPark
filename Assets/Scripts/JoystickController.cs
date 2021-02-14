using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    protected Joystick joystick;
    protected JoyButton joybutton;
    public Rigidbody rb;
    public float speed;
    public float jumpHeight;

    protected bool jump;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<JoyButton>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!jump && joybutton.Pressed)
        {
            jump = true;
            rb.velocity += Vector3.up * jumpHeight;
        }

        if (jump && !joybutton.Pressed)
            jump = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        rb.AddForce(movement * speed);
    }
}
