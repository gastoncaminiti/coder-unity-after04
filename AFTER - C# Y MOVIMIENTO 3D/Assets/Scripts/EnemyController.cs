using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speedEnemy = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EN EL FRAME INICIAL ENEMY...");
        Debug.DrawLine(transform.position, new Vector3(5, 0, 0), Color.red, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
