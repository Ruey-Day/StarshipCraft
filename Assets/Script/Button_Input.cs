using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Input : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Hull(){
        Object_Handler.Instance.TaskOnClick_Number(1);
    }
    public void Half_Hull(){
        Object_Handler.Instance.TaskOnClick_Number(2);
    }
    public void One_Third_Hull(){
        Object_Handler.Instance.TaskOnClick_Number(3);
    }
    public void One_Sixth_Hull(){
        Object_Handler.Instance.TaskOnClick_Number(4);
    }
    public void Five_Sixth_Hull(){
        Object_Handler.Instance.TaskOnClick_Number(5);
    }
    public void One_Half_Hull_two(){
        Object_Handler.Instance.TaskOnClick_Number(6);
    }
    public void One_Sixth_Hull_two(){
        Object_Handler.Instance.TaskOnClick_Number(7);
    }
    public void Five_Sixth_Hull_two(){
        Object_Handler.Instance.TaskOnClick_Number(8);
    }
    public void Gun_1(){
        Object_Handler.Instance.TaskOnClick_Number(100);
    }
    public void Thruster_1(){
        Object_Handler.Instance.TaskOnClick_Number(200);
    }


}
