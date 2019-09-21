using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollision : MonoBehaviour
{
    //public GameObject go;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    go = GetComponent<>();
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    Debug.Log("trololol");
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "KirbyDummy")
        {
            Debug.Log("Lol");
        } else
        {
            Debug.Log("haha");
        }
    }
}
