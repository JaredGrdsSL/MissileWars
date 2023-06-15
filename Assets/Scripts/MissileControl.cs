using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileControl : MonoBehaviour {

    public float direction;

    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + direction);
    }
}
