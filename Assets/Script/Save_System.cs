using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Save_System
{
    public static void Save_Player(Object_Handler Player){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.test";
        FileStream stream = new FileStream(path, FileMode.Create);

        Player_Data data = new Player_Data(Player);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Saved");
    }
    
    public static Player_Data LoadPlayer(){
        string path = Application.persistentDataPath + "/player.test";
        if(File.Exists(path)){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Player_Data data = formatter.Deserialize(stream) as Player_Data;
            stream.Close();

            return data;
        }else{
            Debug.LogError("Save file not found in"+path);
            return null;
        }
    }
}