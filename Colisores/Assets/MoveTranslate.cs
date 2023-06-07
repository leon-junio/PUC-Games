using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTranslate : MonoBehaviour
{
    private float speed = 5f;
    private Vector3 move;

    public void setspeed(float vel)
    {
        this.speed = vel;
		Debug.Log("Velocidade: "+ vel);
    }

    void FixedUpdate()
    {
        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");
        move *= speed * Time.deltaTime;
        this.gameObject.transform.Translate(move);
    }
}

