using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coletavel : MonoBehaviour
{
    public int pontos = 10;
    public GameObject pontos0;
    public GameObject pontos10;

    void Start()
    {
        pontos0.SetActive(true);
        pontos10.SetActive(false);
    }
	
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("bateu!");
            pontos0.SetActive(false);
            pontos10.SetActive(true);
            Destroy(gameObject);
        }
    }
}
