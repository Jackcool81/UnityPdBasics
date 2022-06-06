using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject cube; //public GameObject can get gameobjects we make in unity
    // Start is called before the first frame update, setting up our variables
    void Start()
    {
        
    }

    // Update is called once per frame, so we uise this for things that will constantly bne changin IE Player Movement, Shooting, Player controls 
    void Update()
    {
        Debug.Log(cube.transform.position);
    }
}
