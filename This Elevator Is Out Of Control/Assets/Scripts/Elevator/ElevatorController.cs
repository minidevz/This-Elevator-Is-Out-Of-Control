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
    private AudioSource elevatorMusic;
    #endregion
    void Start()
    {
        startLevel = transform.position;
        elevatorMusic = GetComponent<AudioSource>();
    }

    void Update ( )
    {
        if(onElevator == true)
        {
            elevator.Translate(Vector3.up * speed * Time.deltaTime);

        }
     
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            
            onElevator = true;
            other.transform.SetParent(elevator);
            elevatorMusic.Play();
        }
    }
    private void OnTriggerExit (Collider other)
    {
        if(other.tag == "Player")
        {
            onElevator = false;
            other.transform.SetParent(null);
            elevatorMusic.Stop();
        }
    }

    private void OnTriggerStay (Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Music");
          
        }
    }
}
