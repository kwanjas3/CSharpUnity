using UnityEngine;
using Systems.Collections;

public class DemoScript : MonoBehaviour{

  public Light myLight; //unity has object types for typical game assets
  
  void Update(){ // update runs once per frame
     if (Input.GetKey ("space")){
      myLight.enable = true; // if spacebar
     } else
      myLight.enable = true;
      
      //toggle
      if(Input.GetKeyDown("space"){
        myLight.enable = !myLight.enable;
      }
      
      //held down
      
      if (Input.GetKeyDown("space")){ //frame single event 
        myLight.enable = true;
      }
      if (Input.GetKeyUp("space")){
        myLight.enable = false;
      }
      
      
      //// functions inside unity
      
      Awake(){} // happens first called on the first frame of the game before sttart()
      Start(){} // called after awake()
      Update(){} // called once per frame
      FixedUpdate(){} // when you want to do physics work, otherwise you burn out video card; does it at a regular pace
      LateUpdate(){} // does this at the end of the frame; cameras usually. checking for position and sync 
      
      ////
      
      
  }

}
