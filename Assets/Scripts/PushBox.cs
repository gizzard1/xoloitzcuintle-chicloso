using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBox : MonoBehaviour
{
    public float pushPower=0.5f;

    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if(body == null || body.isKinematic)
        {
            return;
        }

        if(hit.moveDirection.y < -0.3)
        {
            return;
        }

        Vector3 pushDirection = new Vector3(hit.moveDirection.x,0,hit.moveDirection.z);

        body.velocity = pushDirection * pushPower;
    }
}
