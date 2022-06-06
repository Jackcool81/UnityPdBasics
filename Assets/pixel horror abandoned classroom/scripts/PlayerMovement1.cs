using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    private float timeRemaining = 5f;
    public GameObject player; 
    private void Awake()
    {
        //controller = gameObject.GetComponent<CharacterController>();
        //player.GetComponentsInChildren<Light>()[0].intensity = 0;
    }

    // Update is called once per frame
    void Update() //Think of the update method as a loop, that just calls itself everyframe
    {
        player.GetComponentsInChildren<Light>()[0].intensity = 0;
        if (Input.GetKey(KeyCode.F))
        {
            if (timeRemaining > 0) {
                timeRemaining -= Time.deltaTime; 
                player.GetComponentsInChildren<Light>()[0].intensity = 3;
            }
            else {
                player.GetComponentsInChildren<Light>()[0].intensity = 0;
            } 
        }
        else {

            timeRemaining = 5f;
        }

        

    }

}
