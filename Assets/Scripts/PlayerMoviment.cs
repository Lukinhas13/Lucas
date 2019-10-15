using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public Transform Boss;

    private Renderer m_Renderer; 

    public float speed = 1f;

    private Rigidbody m_Rigidbody;

    private PlayerHealth m_PlayerHealth;

    private void Awake()
    {
        m_Renderer = GetComponent<Renderer>();

        m_Rigidbody = GetComponent<Rigidbody>();

        m_PlayerHealth = GetComponent<PlayerHealth>();
    }

    private void OnEnable()
    {
        
    }
    
 
    void Update()
    {
        Moviment();
    }

    private void OnDisable()
    {
        
    }

    void Moviment()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Se movimentando para frente");

            transform.Translate(0, 0, 0.1f * speed);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Se movimentando para tras");

            transform.Translate(0, 0, 0.1f * -speed);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Se movimentando para esquerda");

            transform.Rotate(0, 0.4f * -speed, 0);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Se movimentando para direita");

            transform.Rotate(0, 0.4f * speed, 0);
        }
    }
    private void Start() 
    {

       
        Debug.Log("Vida: " + m_PlayerHealth.health);

        m_PlayerHealth.health = 50;

        Debug.Log("Vida: " + m_PlayerHealth.health);

        m_Renderer.material.color = Color.green;

    }

    void DoMovement()
    {

    }
       

}
