using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallpcolidehealth : MonoBehaviour
   
{
    public PlayerController player;

    //public HealthControl wallhealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        player.TakeDamage(10);
        Destroy(other.gameObject);
    }
}
