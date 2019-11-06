using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSelectedObjects : MonoBehaviour
{
    public Camera myCamera;
    public GameObject selectItem;
    public GameObject selectedObject;
    void Start()
    {

    }
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(myCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.transform.tag == "unit")
                {
                    if(selectedObject != null)
                    {
                        selectedObject.GetComponent<Unit>().unselected();
                        selectedObject = null;
                    }
                    selectedObject = hit.transform.gameObject;
                    selectedObject.GetComponent<Unit>().selected();
                }
                if (selectedObject != null && hit.transform.tag == "point")
                {
                    selectedObject.GetComponent<Unit>().move(hit.transform.position);

                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            selectedObject.GetComponent<Unit>().unselected();
            selectedObject = null;
        }
    }
    
    void chouseEvent()
    {

    }
    void move()
    {

    }
 }
