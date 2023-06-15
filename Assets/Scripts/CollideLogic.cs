using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideLogic : MonoBehaviour
{
    public GameObject missile; // possible problem

    private void Start()
    {
        missile = DataHandler.currentMissile;
    }

    private void Update()
    {
        this.gameObject.transform.position = missile.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("RedCollide")) {
            DataHandler.score++;
            Destroy(missile);
            Destroy(gameObject);
        } else if(collision.CompareTag("BlueCollide")) {
            DataHandler.score--;
            Destroy(missile);
            Destroy(gameObject);
        }
    }
}
