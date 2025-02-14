using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartParts : MonoBehaviour
{
    public GameObject module;

    public GameObject parts; // 자기 자신 (현재 검사 중인 파츠)

    void Start()
    {
        
    }

    void Update()
    {

    }

    public bool moduleTrace()
    {
        Collider2D moduleCollider = module.GetComponent<Collider2D>();
        Vector2 Position = transform.position; // 현재 오브젝트 위치

        
        if (!moduleCollider.OverlapPoint(Position)) 
        {
            Debug.Log("파츠가 모듈 밖에 있습니다.");
            return false;
        }
        // "Parts" 태그가 붙은 모든 오브젝트 가져오기
        GameObject[] otherParts = GameObject.FindGameObjectsWithTag("Parts");

        foreach (GameObject otherPart in otherParts)
        {
            // 자기 자신은 검사에서 제외
            if (otherPart == parts) continue;

            Collider2D partsCollider = otherPart.GetComponent<Collider2D>();

            if (partsCollider != null && partsCollider.OverlapPoint(Position))
            {
                Debug.Log("파츠가 다른 파츠에 간섭합니다.");
                return false;
            }
        }

        return true;
    }
}
