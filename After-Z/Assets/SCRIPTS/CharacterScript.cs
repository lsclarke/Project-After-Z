using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    //Variables

    public float health;

    [Range(0.0f, 10.0f)]
    public float speed;

    public float jumpPower;



    public void CharacterController()
    {
        Debug.Log("HEALTH: " + getHealth() + Environment.NewLine + "SPEED: " + getSpeed() + Environment.NewLine + "JUMP: " + getJumpPower());   
    }

    //Set health variable, and get the value of the newly set health variable
    public void setHealth(float hp) => health = hp;
    public float getHealth() => health;

    //Set Speed variable, and get the value of the newly set Speed variable
    public void setSpeed(float spd) => speed = spd;
    public float getSpeed() => speed;

    //Set Jump variable, and get the value of the newly set Jump variable
    public void setJumpPower(float jmpPwr) => jumpPower = jmpPwr;
    public float getJumpPower() => jumpPower;

    private void Awake()
    {
        CharacterController();
    }






}
