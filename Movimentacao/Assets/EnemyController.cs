using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform[] waypoints;
    private Vector3 fromPoint, toPoint;
    float origin, comprimento;
    int indice=0;

    void Start()
    {
        fromPoint = waypoints[0].position;
        toPoint = waypoints[1].position;
        origin = Time.time;
        comprimento= Vector3.Distance(fromPoint, toPoint);
    }

    void Update()
    {
        float time = Time.time- origin;
        float vs = (time/comprimento)*3;
        this.transform.position = Vector3.Lerp(fromPoint,toPoint,vs);
        if(Vector3.Distance(this.transform.position,toPoint)==0){
            indice++;
            fromPoint=toPoint;
            if(indice%waypoints.Length == 0){
                indice=0;
            }
            toPoint= waypoints[indice].position;
            comprimento= Vector3.Distance(fromPoint,toPoint);
            origin=Time.time;

        }

    }
}
