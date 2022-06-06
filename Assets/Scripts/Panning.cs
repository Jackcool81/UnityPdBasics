using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panning : MonoBehaviour
{
    public GameObject player;
    public GameObject source;
    public LibPdInstance pdPatch;
    float distanceBetweenXX = 0;
    float distanceBetweenZZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //basing this around the z axis 
        float proxZ = source.transform.position.z;
        float proxX = source.transform.position.x;
        float playZ = player.transform.position.z;
        float playX = player.transform.position.x;
        distanceBetweenZZ = proxZ - playZ;
        distanceBetweenXX = proxX - playX;
        pdPatch.SendFloat("z", distanceBetweenZZ);
        pdPatch.SendFloat("axis", distanceBetweenXX);
        //Debug.Log(proxX);

    }
}
