using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public GameObject Bullet;
    
    public void Firing()
    {
        Debug.Log("TargetFunction이 호출되었습니다!");

        GameObject newBullet = Instantiate(Bullet, transform.position, Quaternion.identity);

        newBullet.SetActive(true);
    }
}
