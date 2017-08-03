using UnityEngine;
using System.Collections;


public class Test : MonoBehaviour{
        void Start(){
                int[] array = new int[5];

                array[0] = 40;
                array[1] = 50;
                array[2] = 56;
                array[3] = 13;
                array[4] = 7;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >=0; i--){
                        Debug.Log(array [i]);
                }
        }

        // Update is called once per frame
        void Update(){

        }
}