using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speedEnemy1 = 4f;
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Rotacion();
        Seguir();
    }


    private void Seguir()
    {
        Vector3 direccion = player.transform.position - transform.position;
        if (direccion.magnitude > 2)
        {
            transform.position += direccion.normalized * speedEnemy1 * Time.deltaTime;
        }
    }

    private void Rotacion()
    {
        Vector3 direccion = player.transform.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(new Vector3(direccion.x, 0, direccion.z));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedEnemy1 * Time.deltaTime);
    }

}
