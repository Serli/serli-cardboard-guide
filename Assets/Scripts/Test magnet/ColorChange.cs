using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour{

    void Start () {
        CardboardMagnetSensor.SetEnabled(true);
    }


	void Update () {

        if (CardboardMagnetSensor.CheckIfWasClicked())
        {
            


            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
            bool collide = Physics.Raycast(ray, out hit); //est ce que ça touche un truc ? 
                                                          //il faut utiliser un physic raycast ou un graphic? 


            if (collide)
            {
                if (hit.collider.tag == "Button")
                {
                    Button bouton = hit.collider.GetComponentInParent<Button>();
                    bouton.onClick.Invoke();
                    Debug.Log("Ca touche un bouton");

                }
                else
                {
                    Debug.Log("Ca touche pas un bouton");
                }
            }
            else
            {
                Debug.Log("Ca touche rien");
            }
            

            CardboardMagnetSensor.Reset();
      

        }
        
    }

}
