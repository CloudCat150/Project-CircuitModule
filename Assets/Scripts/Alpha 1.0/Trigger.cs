 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Gun;

    private void OnMouseDown()
    {
        GunFire gunFire = Gun.GetComponent<GunFire>();
        gunFire.Firing();
    }
}

