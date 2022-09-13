using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform playerTrans;
    Vector3 offSet;

    void Start() {
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        offSet = transform.position -playerTrans.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTrans.position + offSet;
    }
}
