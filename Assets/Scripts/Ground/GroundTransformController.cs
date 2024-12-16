using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTransformController : MonoBehaviour
{
    private GroundSpawnController groundSpawnController;
    private Rigidbody rb;
    [SerializeField] private float endYValue;
    private int groundDirection;
    void Start()
    {
        groundSpawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        CheckGroundVerticalPosition();
    }

    private void CheckGroundVerticalPosition(){
        if(transform.position.y <= endYValue){
            setRigidBodyValues();
            setGroundNewPosition();
        }
    }

    private void setGroundNewPosition(){
        groundDirection = Random.Range(0,2);

            if(groundDirection == 0){
                transform.position = new Vector3(
                    groundSpawnController.lastGroundObject.transform.position.x -1f, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z
                );
            }else{
                 transform.position = new Vector3(
                    groundSpawnController.lastGroundObject.transform.position.x, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z +1f
                );
            }
            groundSpawnController.lastGroundObject = gameObject;
    }

    private void setRigidBodyValues(){
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
