using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    GameObject Ref;
    Object_Handler Handler;

    public GameObject Cockpit;
    Generator Base;


    void Start()
    {
        Ref = GameObject.Find("GameManager");
        Handler = Ref.GetComponent<Object_Handler>();
    }

    // Method to load the scene by name
    public void LoadScene(string sceneName)
    {
        Debug.Log(sceneName);
        Handler.SavePlayer();
        
        StartCoroutine(MyFunctionWithDelay());

        SceneManager.LoadScene(sceneName);
    }

    IEnumerator MyFunctionWithDelay()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(1);

    }
}