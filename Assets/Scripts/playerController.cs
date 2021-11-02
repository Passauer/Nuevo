using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed = 5f;
    public string namePlayer = "Panchito";
    public float scalePlayer = 1.0f;
    public float healthPlayer = 100;
    float rotar;

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
        RotatePlayer();
    }


    void goPlayer()
    {
        float xGo = Input.GetAxis("Horizontal");
        float zGo = Input.GetAxis("Vertical");
        Vector3 goDirection = new Vector3(xGo, 0.0f, zGo);
        transform.Translate(speed * Time.deltaTime * new Vector3(xGo, 0, zGo));
    }

    void healPlayer()
    {
        healthPlayer = healthPlayer + 10;
    }

    void dmgPlayer()
    {
        healthPlayer = healthPlayer - 5;
    }


    private void RotatePlayer()
    {
        rotar += Input.GetAxis("Mouse X");
        Quaternion angulo = Quaternion.Euler(0, rotar, 0);
        transform.localRotation = angulo;
    }





}
