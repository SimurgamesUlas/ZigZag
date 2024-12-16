using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   [SerializeField] private BallData ballDataTransmiter;

   [SerializeField] private float ballmoveSpeed;

   private void Update(){
      setBallMovement();
   }

   private void setBallMovement(){
    transform.position += ballDataTransmiter.getballDirection() * ballmoveSpeed * Time.deltaTime;
   }
}
