using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSwitches : MonoBehaviour {
    private void Start()
    {
        float [] RandomNumbers = new float[3];
        for(int i = 0; i<RandomNumbers.Length; ++i)
            RandomNumbers[i] = Random.value;
        for(int i = 0; RandomNumbers.Length; ++i)
            if (0 < RandomNumbers[i] < (1 / 6))
            {
                
            }
        
       } 
    
   
    }


