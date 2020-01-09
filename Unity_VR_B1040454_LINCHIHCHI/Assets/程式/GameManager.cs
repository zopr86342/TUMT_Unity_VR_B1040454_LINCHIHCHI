using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
  


    public void ThrowPickUp()  //撿起
    {

    }
    public void ThrowDetach(GameObject obj)  //放開
    {
        Destroy(obj);


    }
    public void ThrowHeld()  //持續拿著
    {

    }
	
}
