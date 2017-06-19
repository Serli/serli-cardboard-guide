using UnityEngine;
using System.Collections;

public class CardboardTriggerControlMono : MonoBehaviour
{
    public bool magnetDetectionEnabled = true;

    void Start()
    {
        CardboardMagnetSensor.SetEnabled(magnetDetectionEnabled);
        // Disable screen dimming:
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }

    void Update()
    {
        
        if (!magnetDetectionEnabled) return;
        if (CardboardMagnetSensor.CheckIfWasClicked())
        {
            ///PARTIE IMPROVISEE
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            bool collide = Physics.Raycast(ray, out hit);//merci doc unity
            if (collide && hit.collider.tag == "button")// hit est pas initialisé
            {   
                Transform objectHit = hit.transform;
                Debug.Log("Youpi !"); 
                //GameObject collidedGameObject = hit.collider.gameObject;//on récupère l'objet auquel appartien le collider :D
                //callbackObject = collidedGameObject.GetComponent<TypeDeLObjet>();//on récupère l'objet contenant l'action à effectuer ( ce que tu appèlle avec le Onclic je pense)
                //callbackObject.OnClick();//on appèle la callback sans fautes d'orthographe ;)
                //ChangeScene blabla = this.gameObject.GetComponent<ChangeScene>();
                GameObject collidedGameObject = hit.collider.gameObject;
                //collidedGameObject.GetComponent<SceneChanger>().Change();// ça c'est ok


               }
            ///
            Debug.Log("DO SOMETHING HERE");  // PERFORM ACTION.
       
            CardboardMagnetSensor.ResetClick();
        }
    }

}