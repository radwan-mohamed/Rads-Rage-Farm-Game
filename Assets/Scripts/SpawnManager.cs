using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalprefabs;
    public int animalindex;
    private float startdelay = 2;
    private float spwaninterval = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spwanrandowmanimal", startdelay, spwaninterval);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    void spwanrandowmanimal()
    {
       
        animalindex = Random.Range(0, animalprefabs.Length);
        Vector3 spwanpos = new Vector3(Random.Range(-18, 18), 0, 30);
        Instantiate(animalprefabs[animalindex], spwanpos, animalprefabs[animalindex].transform.rotation);


    }
}
