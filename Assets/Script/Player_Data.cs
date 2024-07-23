using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player_Data{
    public float[] Ship_Data_X = new float[400];
    public float[] Ship_Data_Y = new float[400];
    public float[] Ship_Data_Z = new float[400];
    public int[] Ship_Data_Mode = new int[400];
    public int[] Ship_Data_Rot_X = new int[400];
    public int[] Ship_Data_Rot_Y = new int[400];
    public int[] Ship_Data_Rot_Z = new int[400];
    public int size;

    public Player_Data(Object_Handler Player){
        size = Player.index;
        //Ship_Data = new float[400];
        for(int i = 0; i<Player.index; i++){
            Ship_Data_X[i]= Player.Data_X[i];
            Ship_Data_Y[i]= Player.Data_Y[i];
            Ship_Data_Z[i]= Player.Data_Z[i];

            Ship_Data_Mode[i]= Player.Data_Mode[i];

            Ship_Data_Rot_X[i]= Player.Data_Rot_X[i];
            Ship_Data_Rot_Y[i]= Player.Data_Rot_Y[i];
            Ship_Data_Rot_Z[i]= Player.Data_Rot_Z[i];
        }
    }
}
