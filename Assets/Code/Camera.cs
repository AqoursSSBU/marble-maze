using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform playerTrans;
    Vector3 offSet;
    Vector3 eulerAngles;
    float turnSpeed = 45;
    float x = 0,y = 0,z = 0;

    void Start() {
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        offSet = transform.position - playerTrans.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        
        if(Input.GetKey(KeyCode.W)){
            x-=1;
        }
        if(Input.GetKey(KeyCode.S)){
            x+=1;
        }
        if(Input.GetKey(KeyCode.A)){
            y-=1;
        }
        if(Input.GetKey(KeyCode.D)){
            y+=1;
        }
        eulerAngles += new Vector3(x,y,z) * Time.deltaTime * turnSpeed;
        transform.position = playerTrans.position - transform.forward*offSet.magnitude;
        transform.localEulerAngles=eulerAngles;
        x = 0;
        y = 0;
        z = 0;


        
        
    }
}
