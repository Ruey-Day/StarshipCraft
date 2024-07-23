using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_Manager : MonoBehaviour
{
    GameObject Ref;
    Object_Handler Handler;

    public GameObject Cockpit;
    Generator Base;


    void Start()
    {
        Ref = GameObject.Find("GameManager");
        Handler = Ref.GetComponent<Object_Handler>();

        Base = Cockpit.GetComponent<Generator>();
        Base.LoadPlayer();
    }
    public void Click_Delete(){
        Handler.TaskOnClickRemove();
        Handler.SavePlayer();
    }
    public void Clear_Data(){
        Handler.clear_Data();
    }
    public void Left_Turn(){
        Handler.y_Rotate += 90;
    }
    public void Right_Turn(){
        Handler.y_Rotate -= 90;
    }
    public void Up_Turn(){
        Handler.z_Rotate += 90;
    }
    public void Down_Turn(){
        Handler.z_Rotate -= 90;
    }
    public void Front_Turn(){
        Handler.x_Rotate += 90;
    }
    public void Backend_Turn(){
        Handler.x_Rotate -= 90;
    }
}
