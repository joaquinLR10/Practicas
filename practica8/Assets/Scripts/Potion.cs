using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : VoiceInteractable
{

  
  

   

    public override void VoiceInteract(string action)
       {
          
        if(action=="lifetime")
        {
        GetComponent<AudioSource>().Play();
        }
       

       }
      
       
        
    }