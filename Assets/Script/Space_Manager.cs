using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public SceneChanger Scene;


    public GameObject Astroid;
    public GameObject Cockpit;
    private Generator Base;

    void Start()
    {
        Base = Cockpit.GetComponent<Generator>();
        Base.LoadPlayer();

        Base.enabled = false;

        for(int i = 0; i<100; ++i){
        int randomX = Random.Range(-200, 200);
        int randomY = Random.Range(-200, 200);
        int randomZ = Random.Range(-200, 200);
        Vector3 newPosition;
        newPosition.x = randomX;
        newPosition.y = randomY;
        newPosition.z = randomZ;
        Instantiate(Astroid, newPosition, Quaternion.identity);
        Debug.Log("A created");
        }
    }

    // Update is called once per frame
    bool UpdateActive = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)&&UpdateActive)
        {
            Scene.LoadScene("Menu");
            UpdateActive = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
