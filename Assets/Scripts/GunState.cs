using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunState : MonoBehaviour
{
    public GameObject pistol;
    public GameObject shotgun;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            pistol.SetActive(true);
            shotgun.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            pistol.SetActive(false);
            shotgun.SetActive(true);
        }
    }
}
