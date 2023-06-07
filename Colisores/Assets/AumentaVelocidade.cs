using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentaVelocidade : MonoBehaviour
{
    private float moveSpeed = 25f; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Velocidade aumentada");
            MoveTranslate movwTranslateScript = collision.gameObject.GetComponent<MoveTranslate>();
            if (movwTranslateScript != null)
            {
                Debug.Log(moveSpeed);
                moveTranslateScript.setVelocidade(moveSpeed);
            }
            Destroy(gameObject);
        }
    }
}
