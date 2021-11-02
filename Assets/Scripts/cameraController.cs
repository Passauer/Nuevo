using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject[] camaras;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamaraChange();
    }

    private void CamaraChange()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            camaras[0].SetActive(true);
            camaras[1].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            camaras[1].SetActive(true);
            camaras[0].SetActive(false);
        }
    }
}
