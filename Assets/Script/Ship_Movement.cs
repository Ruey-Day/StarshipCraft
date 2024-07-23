using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    Rigidbody spaceship;
    float verticalMove;
    float horizontalMove;
    float mouseInputX;
    float mouseInputY;
    float rollInput;

    [SerializeField]
    float speedMult = 1f; //1
    [SerializeField]
    float speedMultAngle = 0.5f; //0.2
    [SerializeField]
    float speedRollMultAngle = 0.05f;

    public GameObject Location_child;

    GameObject Ref;
    Object_Handler Handler;
    // Start is called before the first frame update
    void Start()
    {
        Ref = GameObject.Find("GameManager");
        Handler = Ref.GetComponent<Object_Handler>();

        Vector3 childOffset;
        childOffset.x = 0;
        childOffset.y = 0;
        childOffset.z = 0;
        for(int i = 0; i<400; ++i){
            if(Handler.Data_Mode[i] != 200){
                childOffset.x = (childOffset.x+Handler.Data_X[i])/2;
                childOffset.y = (childOffset.y+Handler.Data_Y[i])/2;
                childOffset.z = (childOffset.z+Handler.Data_Z[i])/2;
            }
        }
        Location_child.transform.localPosition = childOffset;


        Cursor.lockState = CursorLockMode.Locked;
        spaceship = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxis("Vertical");
        horizontalMove = Input.GetAxis("Horizontal");
        rollInput = Input.GetAxis("Roll");

        mouseInputX = Input.GetAxis("Mouse X");
        mouseInputY = Input.GetAxis("Mouse Y");
        //Debug.Log(""+verticalMove);
    }
    void FixedUpdate(){
        //Debug.Log(""+verticalMove);
        Vector3 position = Location_child.transform.position;
        spaceship.AddForceAtPosition(spaceship.transform.TransformDirection(Vector3.forward)*verticalMove*speedMult, position ,ForceMode.VelocityChange);
        //spaceship.AddForce(spaceship.transform.TransformDirection(Vector3.right)*horizontalMove*speedMult, ForceMode.VelocityChange);
        spaceship.AddTorque(spaceship.transform.right*speedMultAngle* mouseInputY*-1, ForceMode.VelocityChange);
        spaceship.AddTorque(spaceship.transform.up*speedMultAngle* horizontalMove * 3/10, ForceMode.VelocityChange);

        spaceship.AddTorque(spaceship.transform.forward*speedRollMultAngle*rollInput, ForceMode.VelocityChange);
    }
}
