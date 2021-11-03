using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenWall : MonoBehaviour
{

    [SerializeField] private Transform[] posiciones;
    [SerializeField] private Transform spawn;
    private float cooldown = 2;
    private float tempPortal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Time.deltaTime > tempPortal)
            {
                tempPortal = Time.deltaTime + cooldown;
            }
            else
            {
                spawn = posiciones[Random.Range(0, posiciones.Length - 1)];
                Vector3 direccion = spawn.position - transform.position;
                transform.position += direccion;
            }
        }

    }
}
