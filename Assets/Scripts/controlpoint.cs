using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlpoint : MonoBehaviour
{
    float xroat, yroat = 0f;
    public Rigidbody ball;
    public float rotatespeed = 5f;
    public LineRenderer Line;
    public float shootpower = 30f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position;
        if(Input.GetMouseButton(0))
        {
            xroat += Input.GetAxis("Mouse X") * rotatespeed;
            yroat += Input.GetAxis("Mouse Y") * rotatespeed;
            transform.rotation = Quaternion.Euler(yroat, xroat, 0f);
            Line.gameObject.SetActive(true);
            
            Line.SetPosition(0, transform.position);
            Line.SetPosition(1, transform.position + transform.forward * 4f);
            if(yroat<-35)
            {
                yroat = -35f;

            }


        }
        if(Input.GetMouseButtonUp(0))
        {
            ball.velocity = transform.forward * shootpower;
            Line.gameObject.SetActive(false);

        }
    }
}
