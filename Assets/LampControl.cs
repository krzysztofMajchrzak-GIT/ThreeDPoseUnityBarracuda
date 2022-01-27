using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LampControl : MonoBehaviour
{
    public Slider sliderX;
    public Slider sliderY;
    public Slider sliderZ;
    public Slider intensity;
    public Slider range;
    public bool thisLamp = true;
    private Transform tran;
    public float startingRotationx;
    public float startingRotationy;
    public float startingRotationz;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("dfsfddsfsdffsd");
        
        tran = this.gameObject.GetComponent<Transform>();
        startingRotationx = tran.rotation.eulerAngles.x - 360.0f;
        startingRotationy = tran.rotation.eulerAngles.y - 360.0f;
        startingRotationz = tran.rotation.eulerAngles.z - 360.0f;

       // Debug.Log(startingRotationx);
    }
    public void changeRotation()
    {
        if (thisLamp ==false)
            return;
        
        var rotationVector = transform.rotation.eulerAngles;

        if ( sliderX.IsActive())
        {
            
            rotationVector.x = sliderX.value + startingRotationx;
            rotationVector.y = sliderY.value + startingRotationy;
            rotationVector.z = sliderZ.value + startingRotationz;
            //Debug.Log(transform.rotation);
            //Debug.Log(rotationVector.x + " X");
            //Debug.Log(rotationVector.y + " Y");
            //Debug.Log(rotationVector.z + " Z");
            //Debug.Log(rotationVector);

            transform.rotation = Quaternion.Euler(new Vector3(rotationVector.x, rotationVector.y, rotationVector.z));

            
        }
    }

    public void changeIntensity()
    {
        if (thisLamp == false)
            return;
        GameObject child = this.transform.GetChild(0).gameObject;

        if (sliderX.IsActive())
        {

            child.GetComponent<Light>().intensity = intensity.value;


        }
    }
    public void changeRange()
    {
        if (thisLamp == false)
            return;
        GameObject child = this.transform.GetChild(0).gameObject;

        if (sliderX.IsActive())
        {

            child.GetComponent<Light>().range = range.value;


        }
    }
}
