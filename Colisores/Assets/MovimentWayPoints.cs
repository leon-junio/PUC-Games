using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentWayPoints : MonoBehaviour
{
    public Transform waypoint1;
    public Transform waypoint2;
    public float speed = 1f;
    private float progress = 0f;
    void Update()
    {
		//calculo do progresso utilizando deltatime
        progress += Time.deltaTime * speed;
        if (progress > 1f)
        {
			speed *= -1f;
            progress = 1f; 
        }else if (progress < 0f)
        {
            progress = 0f;
            speed *= -1f;
        }
        transform.position = new Vector3(waypoint1.position, waypoint2.position, progress);
    }
}
