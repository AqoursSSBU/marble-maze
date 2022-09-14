using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{

    public float speed = 10, death = -20, zspeed = 0, xspeed = 0;
    Rigidbody _rigidbody;
    Transform camtrans;
    Vector3 forward,right;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        camtrans = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        zspeed = 0;
        xspeed = 0;
        forward=camtrans.forward;
        right=camtrans.right;
        forward.y=0;
        right.y=0;
        // float zspeed = Input.GetAxis("Vertical") * speed;
        // float xspeed = Input.GetAxis("Horizontal") * speed;
        if(Input.GetKey(KeyCode.UpArrow)){
            xspeed+=speed;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            xspeed-=speed;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            zspeed-=speed;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            zspeed+=speed;
        }
        
        _rigidbody.AddForce(xspeed*forward);
        _rigidbody.AddForce(zspeed*right);

        if(transform.position.y < death){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
