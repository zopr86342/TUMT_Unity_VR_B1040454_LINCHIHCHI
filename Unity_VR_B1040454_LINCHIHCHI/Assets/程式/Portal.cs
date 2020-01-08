using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Portal : MonoBehaviour {
    public GameObject fnial;

    private void OnTriggerEnter(Collider other)
    {
        if (other .tag == "鑰匙" && GameManager.haveKey)
        {
            print("已觸發");
            GameObject.Find("結束畫面").SetActive(true);
        }
    }
}
