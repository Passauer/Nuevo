using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed = 5f;
    public string namePlayer = "Panchito";
    public float scalePlayer = 1.0f;
    public float healthPlayer = 100;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1.3f, 2.0f, -4f);
        transform.localScale = new Vector3(scalePlayer, scalePlayer, scalePlayer);
    }

    // Update is called once per frame
    void Update()
    {
        goPlayer();
    }


    void goPlayer()
    {
        float xGo = Input.GetAxis("Horizontal");
        float zGo = Input.GetAxis("Vertical");
        Vector3 goDirection = new Vector3(xGo, 0.0f, zGo);
        transform.position += goDirection * speed * Time.deltaTime;
    }

    void healPlayer()
    {
        healthPlayer = healthPlayer + 10;
    }

    void dmgPlayer()
    {
        healthPlayer = healthPlayer - 5;
    }








}
