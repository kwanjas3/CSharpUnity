using UnityEngine;
using Systems.Collections;

//saving prefabs as assets. basically creating file can be dragged and dropped to be reused. chests, missiles.

[System.Serializable] // required for custom classes to hold data to allow unity to see it
public class myData {
    public int x;
    public int y;
}

public class DemoScript : MonoBehaviour{

  public Light myLight; //unity has object types for typical game assets
  int myvar = 1;
  
  void Awake(){
    Debug.Log(myvar);
  }
  
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
