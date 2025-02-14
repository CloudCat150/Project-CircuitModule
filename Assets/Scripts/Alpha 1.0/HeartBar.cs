using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBar : MonoBehaviour
{
    public List<GameObject> heartParts = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HeartBarUI(float health)
    {
        for(int i = (int)((health+1)/2) ; i<heartParts.Count; i++)
        {
            heartParts[i].SetActive(false);
        }

    }
}
