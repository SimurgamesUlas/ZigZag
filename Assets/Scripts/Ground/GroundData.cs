using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundData : MonoBehaviour
{
   [SerializeField] private GroundFallController groundFallController;

   public void setGroundRigidBodyValues(){

        StartCoroutine(groundFallController.setRigidBodyValues());

   }
}
