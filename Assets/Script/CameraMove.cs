using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 5.0f;
    //private float x;
    //private float y;
    //public float sensitivity = -1f;
    //private Vector3 rotate;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //y = Input.GetAxis("Mouse X");
        //x = Input.GetAxis("Mouse Y");
        //rotate = new Vector3(x, y * sensitivity, 0);
        //transform.eulerAngles = transform.eulerAngles - rotate;

    }
}
