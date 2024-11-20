using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public float speed;
    public float angle;
    public Vector3 direction;
    public bool canOpen;

    // Start is called before the first frame update
    void Start()
    {
        angle = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Round(transform.eulerAngles.y) != angle)
        {
            transform.Rotate(direction * speed);
        }

        if (canOpen)
        {
            angle = 80;
            direction = Vector3.up;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "box")
        {
            canOpen = true; // Asignar true en lugar de comparar
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "box")
        {
            canOpen = false; // Asignar false en lugar de comparar
        }
    }
}
