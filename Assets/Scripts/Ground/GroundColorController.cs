using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterail;
    [SerializeField] private Color[] colors;
    private int colorIndex = 0;

    [SerializeField] private float lerpValue;
    [SerializeField] private float time;
    private float currentTime;


    private void Update(){
        SetColorChangeTime();
        SetGroundMaterailSmoothColorChange();
    }

    private void SetColorChangeTime(){
        if(currentTime <=0){
            CheckColorIndexValue();
            currentTime = time;
          
        }else{
        currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue(){
        colorIndex++;

        if(colorIndex >= colors.Length){
            colorIndex = 0;
        }
    }

    private void SetGroundMaterailSmoothColorChange(){
        groundMaterail.color = Color.Lerp(groundMaterail.color , colors[colorIndex], lerpValue * Time.deltaTime);
    }

    private void OnDestroy(){
        groundMaterail.color = colors[1];
    }
}
