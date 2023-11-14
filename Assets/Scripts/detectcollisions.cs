using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectcollisions : MonoBehaviour
{
    public double flag;
    public int c=0;

    // Start is called before the first frame update
    void Start()
    {
        flag = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (c != 0)
        {
            flag = flag+0.01;  
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        c = 1;
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
