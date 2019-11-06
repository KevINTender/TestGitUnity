using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    Vector3 point;
    public GameObject pointObject;
    public GameObject selectedObject;
    void Start()
    {
        point = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, point, Time.deltaTime);
    }
    public void move(Vector3 moveVector)
    {
        point = moveVector;
        pointObject.SetActive(true);
        pointObject.transform.position = point;
      
        transform.GetComponent<SpriteRenderer>().flipX = (point.x > transform.position.x)?true:false;
 
    }
    public void selected()
    {
        selectedObject.SetActive (true);
    }
    public void unselected()
    {
        selectedObject.SetActive(false);
        pointObject.SetActive(false);
    }
}
