using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveCol : MonoBehaviour
{
    public int rutina;
    public float positionDif;
    public float cronometro;
    public Quaternion angulo;
    private float grado;
    public float moveSpeed = 10f;    // Velocidad de movimiento horizontal
    public float moveSpeedPersecution = 15f;    // Velocidad de movimiento horizontal
    public GameObject target;
    void Start()
    {
        target = GameObject.Find("principe");
    }

    void comportamiento_enemigo()
    {
        if(Vector3.Distance(transform.position, target.transform.position) > 35){
            cronometro+=1*Time.deltaTime;
            if(cronometro >= 2)
            {
                rutina = Random.Range(0,2);
                cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    break;

                case 1:
                    grado = Random.Range(0,360);
                    angulo = Quaternion.Euler(0,grado,0);
                    rutina++;
                    break;
                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                    break;
            }
        }else{
            var lookPos = target.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);

            Rigidbody rb = target.GetComponent<Rigidbody>();

            float speedMagnitude = rb.velocity.magnitude-10f;

            transform.rotation = Quaternion.RotateTowards(transform.rotation,rotation,3);
            if(speedMagnitude > 0f){
                transform.Translate(Vector3.forward * speedMagnitude * Time.deltaTime); 
            }else{
                transform.Translate(Vector3.forward * moveSpeedPersecution * Time.deltaTime); 
            }
        }
    }
    void Update()
    {
        comportamiento_enemigo();
        positionDif = Vector3.Distance(transform.position, target.transform.position);
    }

}