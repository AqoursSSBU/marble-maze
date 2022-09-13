using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{

    public float speed = 10, death = -20;
    Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float zspeed = Input.GetAxis("Vertical") * speed;
        float xspeed = Input.GetAxis("Horizontal") * speed;
        _rigidbody.AddForce(new Vector3(xspeed,0,zspeed));

        if(transform.position.y < death){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
