using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    public float speed = 5f;
    private Vector3 previousPosition;
    public Vector3 direction;

    Vector3 Final_position = new Vector3();
    // Update is called once per frame
    void Start(){
            direction = new Vector3();

            cam.transform.position = new Vector3();

            cam.transform.Rotate(new Vector3(1, 0, 0), direction.y*180);
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x*180, Space.World);
            cam.transform.Translate(new Vector3(0,0,-10));
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
    }
    void Update()
    {
        Vector3 moveDirection = new Vector3();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection += Vector3.right; // Move forward
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection += Vector3.left; // Move backward
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection += Vector3.forward; // Move left
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection += Vector3.back; // Move right
        }
        
        Final_position += moveDirection* speed* Time.deltaTime;
        if(Input.GetKey(KeyCode.LeftShift)){
        if(Input.GetMouseButtonDown(0)){
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        if(Input.GetMouseButton(0)){
            direction = previousPosition-cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position = Final_position;
            //moveDirection* Time.deltaTime;

            cam.transform.Rotate(new Vector3(1, 0, 0), direction.y*180);
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x*180, Space.World);
            cam.transform.Translate(new Vector3(0,0,-10));
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        }else{
            //Debug.Log("Run");
            cam.transform.position = Final_position;
            cam.transform.Translate(new Vector3(0,0,-10));
            //previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}