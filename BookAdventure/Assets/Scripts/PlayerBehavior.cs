using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
    //Declares two public variables to be used as multipliers:
    //MoveSpeed for how fast the player goes forward and back
    //RotateSpeed for how fast the player rotates left and right

    //1
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    //Declares two private variables to hold inputs from the player, initially set with no value
    //v_Input will store vertical acis input, _hInput will store horizontal axis input

    //2
    private float _vInput;
    private float _hInput;

    private Rigidbody _rb;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis("Vertical") detects qhen the up arrow, down arrow, W, or S
        //key is pressed and multiplies that value by MoveSpeed
        //Up arrow and W keys return a value of 1, which will move the player
        //in the forward (positive) position
        //The opposite for the down arrow and S keys, which return -1 and makes the 
        //player move backwards in the negative direction

        //
        //3
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        //4
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;


        /*
        //5
        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        //6
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
        */
    }

    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _hInput;

        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);

        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}
