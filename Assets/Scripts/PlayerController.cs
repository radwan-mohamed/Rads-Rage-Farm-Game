using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public float horizontalInput;
    public float speed= 10.0f;
    public float xRange =18;
    
    public int maxHealth = 100;
    public int currentHealth;
    public HealthControl healthBar;
    public int damage=10;
    
    public GameObject projectilePrefab;


    public Scoresci ho;
    public Gameoverscreen gameoverscreen;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {   
        if (transform.position.x <-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);

        }

        if (currentHealth == 0)
            gameover();


    }

    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    public void gameover()
    {
        gameoverscreen.Setup(ho.bestscore);

    }
    


}
