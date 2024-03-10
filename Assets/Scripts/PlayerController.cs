using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionProperty moveButton;
    public AudioSource sfxWalk;
    
    private bool isMoving = false;
  
    // Update is called once per frame
    void Update()
    {
      
        if (moveButton.action.WasPressedThisFrame())
        {
            // isMoving = true;
            sfxWalk.Play();
            
        }
        if (moveButton.action.WasReleasedThisFrame())
        {
            // isMoving = false;
            sfxWalk.Stop();
        }
        
        //Untuk SFX isMoving = jika bergerak
        // if (isMoving)
        // {
        //     if (!sfxWalk.isPlaying)
        //     {
                
        //     }
        // }

        // if (!isMoving)
        // {
        //     sfxWalk.Stop();
        // }

    }


}
