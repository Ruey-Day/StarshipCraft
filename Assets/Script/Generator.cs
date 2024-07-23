using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]

public class Generator : MonoBehaviour
{
    public static Generator Instance { get; private set; }


    int record;
    
    public GameObject Hull;
    public GameObject Half_Hull;
    public GameObject One_Third_Hull;
    public GameObject One_Sixth_Hull;
    public GameObject Five_Sixth_Hull;
    public GameObject One_Half_Hull_two;
    public GameObject One_Sixth_Hull_two;
    public GameObject Five_Sixth_Hull_two;
    // public GameObject Armor;
    // public GameObject Half_Armor;
    // public GameObject Light_Armor;
    // public GameObject Light_Half_Armor;
    // public GameObject One_Sixth_Light_Armor;
    // public GameObject Five_Sixth_Light_Armor;
    public GameObject Gun_1;
    public GameObject Thruster_1;
    
    GameObject Ref;
    
    Object_Handler Handler;

    void Start()
    {
        Ref = GameObject.Find("GameManager");
        Handler = Ref.GetComponent<Object_Handler>();
        record = Handler.index;
        Debug.Log("Done");

        
    }

    void OnMouseDown()
    {
        Debug.Log("Bug");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 localHitPoint = hit.transform.InverseTransformPoint(hit.point);
            localHitPoint.Normalize();

            if (Mathf.Abs(localHitPoint.x) > Mathf.Abs(localHitPoint.y) && Mathf.Abs(localHitPoint.x) > Mathf.Abs(localHitPoint.z))
            {
                if (localHitPoint.x > 0)
                    ClickedRight();
                else
                    ClickedLeft();
            }
            else if (Mathf.Abs(localHitPoint.y) > Mathf.Abs(localHitPoint.x) && Mathf.Abs(localHitPoint.y) > Mathf.Abs(localHitPoint.z))
            {
                if (localHitPoint.y > 0)
                    ClickedTop();
                else
                    ClickedBottom();
            }
            else
            {
                if (localHitPoint.z > 0)
                    ClickedFront();
                else
                    ClickedBack();
            }
        }
    }

    void ClickedRight()
    {
        Debug.Log("Right side clicked");
        AddCube(Vector3.right, Handler.GetMode(), true);
    }

    void ClickedLeft()
    {
        Debug.Log("Left side clicked");
        AddCube(Vector3.left, Handler.GetMode(), true);
    }

    void ClickedTop()
    {
        Debug.Log("Top side clicked");
        AddCube(Vector3.up, Handler.GetMode(), true);
    }

    void ClickedBottom()
    {
        Debug.Log("Bottom side clicked");
        AddCube(Vector3.down, Handler.GetMode(), true);
    }

    void ClickedFront()
    {
        Debug.Log("Front side clicked");
        AddCube(Vector3.forward, Handler.GetMode(), true);
    }

    void ClickedBack()
    {
        Debug.Log("Back side clicked");
        AddCube(Vector3.back, Handler.GetMode(), true);
    }
    
    void AddCube(Vector3 direction, int m, bool kind)
    {
        Vector3 newPosition = transform.position + direction;
        if(m == 1){
            GameObject newCube = Instantiate(Hull, newPosition, Quaternion.identity);
            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        if(m == 2){
            GameObject newCube = Instantiate(Half_Hull, newPosition, Quaternion.identity);
            //Left
            newCube.transform.Rotate(Handler.x_Rotate,Handler.y_Rotate,Handler.z_Rotate);

            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        if(m == 3){
            GameObject newCube = Instantiate(One_Third_Hull, newPosition, Quaternion.identity);
            //Left
            newCube.transform.Rotate(Handler.x_Rotate,Handler.y_Rotate,Handler.z_Rotate);

            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        if(m == 4){
            GameObject newCube = Instantiate(One_Sixth_Hull, newPosition, Quaternion.identity);
            //Left
            newCube.transform.Rotate(Handler.x_Rotate,Handler.y_Rotate,Handler.z_Rotate);

            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        if(m == 5){
            GameObject newCube = Instantiate(Five_Sixth_Hull, newPosition, Quaternion.identity);
            //Left
            newCube.transform.Rotate(Handler.x_Rotate,Handler.y_Rotate,Handler.z_Rotate);

            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        if(m == 6){
            GameObject newCube = Instantiate(One_Half_Hull_two, newPosition, Quaternion.identity);
            //Left
            newCube.transform.Rotate(Handler.x_Rotate,Handler.y_Rotate,Handler.z_Rotate);

            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        if(m == 7){
            GameObject newCube = Instantiate(One_Sixth_Hull_two, newPosition, Quaternion.identity);
            //Left
            newCube.transform.Rotate(Handler.x_Rotate,Handler.y_Rotate,Handler.z_Rotate);

            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        if(m == 8){
            GameObject newCube = Instantiate(Five_Sixth_Hull_two, newPosition, Quaternion.identity);
            //Left
            newCube.transform.Rotate(Handler.x_Rotate,Handler.y_Rotate,Handler.z_Rotate);

            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        
        if(m == 100){
            GameObject newCube = Instantiate(Gun_1, newPosition, Quaternion.identity);


            newCube.transform.Rotate(Handler.x_Rotate,Handler.y_Rotate,Handler.z_Rotate);
            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        if(m == 200){
            GameObject newCube = Instantiate(Thruster_1, newPosition, Quaternion.identity);
            if(transform.parent == null){
            newCube.transform.SetParent(transform);
            }else{
            newCube.transform.SetParent(transform.parent);
            }
        }
        if(m == 0){
            int search = 0;
            while((gameObject.transform.position.x != Handler.Data_X[search])||
            (gameObject.transform.position.y != Handler.Data_Y[search])||
            (gameObject.transform.position.z != Handler.Data_Z[search])){
                ++search;
            }
            if(kind){
            Handler.remove_Data(search);
            Destroy(gameObject);
            }
        }
        if(kind){
            Handler.UpdateData(newPosition.x, newPosition.y, newPosition.z, m);
        }
     }
    
    public void LoadPlayer(){
        Debug.Log("LoadPlayer");
        Handler.Load();
        foreach (Transform child in transform)
            {
                if((child.name != "Main Camera")&&(child.name != "Local_Point")){
                    Destroy(child.gameObject);
                }
            }
        AddCube(transform.position, 1, true);
        for(int i = 0; i<Handler.index; ++i){
            Vector3 TempPosition;
            TempPosition.x = Handler.Data_X[i];
            TempPosition.y = Handler.Data_Y[i];
            TempPosition.z = Handler.Data_Z[i];

            Handler.x_Rotate = Handler.Data_Rot_X[i];
            Handler.y_Rotate = Handler.Data_Rot_Y[i];
            Handler.z_Rotate = Handler.Data_Rot_Z[i];

            int mode = Handler.Data_Mode[i];
            AddCube(TempPosition, mode, false);
        }
        Handler.x_Rotate = 0;
        Handler.y_Rotate = 0;
        Handler.z_Rotate = 0;

        // test
        //ClickedRight();
    }
    public void SavePlayer(){
        Handler.SavePlayer();
    }
}
