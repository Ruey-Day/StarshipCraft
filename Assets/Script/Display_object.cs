using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_object : MonoBehaviour
{
    public Transform cameraTransform;

    // [SerializeField] float rotationSpeed = 100f;
    // bool dragging = false;
    //Rigidbody rb;
    int Rotate_X = 0;
    int Rotate_Y = 0;
    int Rotate_Z = 0;

    public Mesh Hull;
    public Mesh Half_Hull;
    public Mesh One_Third_Hull;
    public Mesh One_Sixth_Hull;
    public Mesh Five_Sixth_Hull;
    public Mesh One_Half_Hull_two;
    public Mesh One_Sixth_Hull_two;
    public Mesh Five_Sixth_Hull_two;

    public Mesh Gun_1;
    public Mesh Thruster_1;

    GameObject Ref;
    Object_Handler Handler;
    MeshFilter meshFilter;

    void Start(){
        

        transform.rotation = Quaternion.Inverse(cameraTransform.rotation);

        Ref = GameObject.Find("GameManager");
        Handler = Ref.GetComponent<Object_Handler>();
        meshFilter = GetComponent<MeshFilter>();
        //rb= GetComponent<Rigidbody>();
        //initialRotationEuler = transform.eulerAngles;
        Handler.x_Rotate = 0;
        Handler.y_Rotate = 0;
        Handler.z_Rotate = 0;
    }
    // void OnMouseDrag(){
    //     dragging = true;
    // }
    bool Change_Update = false;
    void Update()
    {
        if(Handler.GetMode() == 1){
            meshFilter.mesh = Hull;
        }
        if(Handler.GetMode() == 2){
            meshFilter.mesh = Half_Hull;
        }
        if(Handler.GetMode() == 3){
            meshFilter.mesh = One_Third_Hull;
        }
        if(Handler.GetMode() == 4){
            meshFilter.mesh = One_Sixth_Hull;
        }
        if(Handler.GetMode() == 5){
            meshFilter.mesh = Five_Sixth_Hull;
        }
        if(Handler.GetMode() == 6){
            meshFilter.mesh = One_Half_Hull_two;
        }
        if(Handler.GetMode() == 7){
            meshFilter.mesh = One_Sixth_Hull_two;
        }
        if(Handler.GetMode() == 8){
            meshFilter.mesh = Five_Sixth_Hull_two;
        }
        if(Handler.GetMode() == 100){
            meshFilter.mesh = Gun_1;
        }
        if(Handler.GetMode() == 200){
            meshFilter.mesh = Thruster_1;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.rotation = Quaternion.Inverse(cameraTransform.rotation);
            transform.Rotate(Rotate_X, Rotate_Y, Rotate_Z);
        }
    }
    public void Display_Left_Turn(){
        transform.Rotate(0, 90, 0);
        Rotate_Y += 90;
        //Debug.Log("Left_Turn");
    }
    public void Display_Right_Turn(){
        transform.Rotate(0, -90, 0);
        Rotate_Y -= 90;
    }
    public void Display_Up_Turn(){
        transform.Rotate(0, 0, 90);
        Rotate_Z += 90;
    }
    public void Display_Down_Turn(){
        transform.Rotate(0, 0, -90);
        Rotate_Z -= 90;
    }
    public void Display_Front_Turn(){
        transform.Rotate(90, 0, 0);
        Rotate_X += 90;
    }
    public void Display_Backend_Turn(){
        transform.Rotate(-90, 0, 0);
        Rotate_X -= 90;
    }
    // void FixedUpdate(){
    //     if(dragging){
    //         float x = Input.GetAxis("Mouse X")*rotationSpeed*Time.fixedDeltaTime;
    //         float y = Input.GetAxis("Mouse Y")*rotationSpeed*Time.fixedDeltaTime;

    //         rb.AddTorque(Vector3.down*x);
    //         rb.AddTorque(Vector3.right*y);

    //     }
       
    // }   
}