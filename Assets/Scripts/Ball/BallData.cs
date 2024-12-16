using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData : MonoBehaviour
{
    [SerializeField] private BallInputController ballInputController;
    public Vector3 getballDirection(){
        return ballInputController.ballDirection;
    }
}
