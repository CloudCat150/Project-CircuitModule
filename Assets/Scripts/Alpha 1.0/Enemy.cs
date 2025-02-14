using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;

    public GameObject HeartBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnHit(float dmg)
    {
        health -= dmg;

        if( health <= 0 ) gameObject.SetActive(false);

        //Health 로 채력바 호출
        HeartBar heartBar = HeartBar.GetComponent<HeartBar>();
        heartBar.HeartBarUI(health);

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Bullet bullet = collider.gameObject.GetComponent<Bullet>();
        if ( collider.gameObject.tag == "Bullet")
        {
            OnHit(bullet.dmg);
            Destroy(collider.gameObject);
        }
    }
}
