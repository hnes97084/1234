using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ 
    private void Awake()
    {
        Debug.Log(message:"Awake");
    }
    private void Start()
    {
        Debug.Log(message:$"Start");
    }
    private void OnEnable()
    {
        Debug.Log(message:$"OnEnable");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(message:$"OnCollisionEnter2D");
        col.gameObject.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(message:"OnTriggerEnter2D");
        gameObject.SetActive(false);
        other.gameObject.SetActive(false);
    }
    


}
