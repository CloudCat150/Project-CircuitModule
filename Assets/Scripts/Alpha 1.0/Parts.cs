using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts : MonoBehaviour
{
    Vector2 offset;

    public List<GameObject> partPart = new List<GameObject>();
    bool isDragging = false;

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x - offset.x, mousePosition.y - offset.y, transform.position.z);
        }
    }

    private void OnMouseDown()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = mousePosition - (Vector2)transform.position;
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
        for( int i = 0; i < partPart.Count; i++)
        {
            PartParts partParts = partPart[i].GetComponent<PartParts>();
            Debug.Log(partParts.moduleTrace());
            if(partParts.moduleTrace() == false) return;
        }
        transform.position = new Vector3(Mathf.Floor((float)transform.position.x) + 0.5f, Mathf.Floor((float)transform.position.y) + 0.5f, transform.position.z);

    }
}
