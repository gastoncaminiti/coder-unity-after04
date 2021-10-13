using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speedEnemy = 1.0f;
    public GameObject puntoInicial;
    public GameObject puntoFinal;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EN EL FRAME INICIAL ENEMY...");
        
        transform.position = puntoInicial.transform.position;
        transform.localScale = puntoInicial.transform.localScale;
        Debug.DrawLine(transform.position,puntoFinal.transform.position , Color.red, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        //transform.position += new Vector3(speedEnemy, 0, 0) * Time.deltaTime;
        //transform.position = transform.position + new Vector3(speedEnemy, 0, 0);
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        transform.Translate(speedEnemy * Time.deltaTime * Vector3.right);
    }
}
