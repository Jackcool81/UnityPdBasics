using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoint;
    int current = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 0.001f; //Way Point Radius
    public Animator animator;

    void Start() {
       animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(current);
        if (current >= waypoint.Length) {
                animator.SetFloat("X", -1);          
            }
        if (Vector3.Distance(waypoint[current].transform.position, transform.position) < WPradius){
            if (current == 0) {
                transform.localEulerAngles = new Vector3(0, 180, 0);
            }
            if (current == 1) {
                transform.localEulerAngles = new Vector3(0, -90, 0);
            }
            if (current == 2) {
                transform.localEulerAngles = new Vector3(0, 180, 0);
            }
            if (current == 3) {
                transform.localEulerAngles = new Vector3(0, 90, 0);
            }
            if (current == 4) {
                transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            if (current == 5) {
                transform.localEulerAngles = new Vector3(0, -90, 0);

            }
            if (current == 6) {
                transform.localEulerAngles = new Vector3(0, 180, 0);
            }
            if (current == 7) {
                transform.localEulerAngles = new Vector3(0, 90, 0);
                animator.SetFloat("X", 1000);
            }
            current++;
            
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoint[current].transform.position, Time.deltaTime * speed);
       // transform.LookAt(waypoint[current].transform);
        animator.SetFloat("X", transform.position.x);
    }
}
