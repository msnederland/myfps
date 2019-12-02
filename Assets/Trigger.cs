using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Transform target;
    public GameObject my_target;

    void OnTriggerEnter(Collider other) 
     {
          Debug.Log("object entered trigger area");

     }

     void OnTriggerStay(Collider other) 
     {
          //Debug.Log("object is in trigger area");
          if (Input.GetButtonDown("Use")) {
               Debug.Log("Use action!");
               //TargetJ          
               //target.localPosition = Vector3.Lerp(target.localPosition, targetPosition, Time.deltaTime * speed);
               target.Translate(0, Time.deltaTime * 0.05f , 0);
               my_target.GetComponent<MovementController>().MoveElevetorUp();
          
               //rb.AddForce(transform.up * 50f);
          }

     }

     void OnTriggerExit(Collider other) 
     {
          Debug.Log("object left trigger area");
     }

}
