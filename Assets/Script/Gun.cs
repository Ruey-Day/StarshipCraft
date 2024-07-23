using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gun : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject Prefab;
    public float bulletspeed = 10;
    public bool Active = false;
    string sceneName;

    void Start(){
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if(sceneName == "Galaxy"){
            Active = true;
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)&&Active){
            var bullet = Instantiate(Prefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward*bulletspeed;
        }
    }
}
