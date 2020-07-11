using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{

    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    [HideInInspector]
    public bool onElevator;
    public float speed;
    private Vector3 startLevel;
    private Vector3 currentLevel;
    public Transform[] levels;
    public Transform elevator;
    #endregion
    void Start()
    {
        startLevel = transform.position;
        Debug.Log(startLevel);
    }

    void Update ( )
    {
        if(onElevator == true)
        {
            elevator.Translate(Vector3.up * speed * Time.deltaTime);
            Debug.Log("Yes");
        }
        else
        {

        }
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            
            onElevator = true;
            other.transform.SetParent(elevator);
        }
    }
    private void OnTriggerExit (Collider other)
    {
        if(other.tag == "Player")
        {
            onElevator = false;
            other.transform.SetParent(null);
        }
    }
}
