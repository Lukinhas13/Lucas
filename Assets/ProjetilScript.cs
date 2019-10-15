using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ProjetilScript : MonoBehaviour
{

    private float timeLimit = 3f;

    private float timer = 0;

    private void Start()
    {

    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeLimit)
        {
            timer = 0;

            Destroy(gameObject);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Nome do Objeto:" + other.gameObject.name);
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.SetActive(false);

            ScoreManager score;

            score = GameObject.Find("Score").GetComponent<ScoreManager>();

            score.Points = 10;

        }
    }



    
}
