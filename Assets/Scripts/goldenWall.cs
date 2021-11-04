using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldenWall : MonoBehaviour
{

    [SerializeField] private Transform[] posiciones;
    private Transform spawn;

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
            Invoke("moverPared", 2f);
    }

    private void moverPared()
    {
        spawn = posiciones[Random.Range(0, posiciones.Length - 1)];
        Vector3 direccion = spawn.position - transform.position;
        transform.position += direccion;
    }
}
