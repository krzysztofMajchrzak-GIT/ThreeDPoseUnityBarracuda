using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePoint : MonoBehaviour
{
    public GameObject Lamp1;
    public GameObject Lamp2;
    public GameObject Lamp3;
    public Slider sliderX;
    public Slider sliderY;
    public Slider sliderZ;
    public Camera camera;
    public GameObject GUI;
    public Slider intensity;
    public Slider range;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                //Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "Lamp")
                {
                    GUI.SetActive(true);
                    camera.GetComponent<CameraMover>().enabled = false;
                    if (hitInfo.transform.gameObject.name == "Lampa Pierwsza")
                    {
                        
                        Lamp1.GetComponent<LampControl>().thisLamp = true;
                        Lamp2.GetComponent<LampControl>().thisLamp = false;
                        Lamp3.GetComponent<LampControl>().thisLamp = false;
                        sliderX.value = 0;
                        sliderY.value = 0;
                        sliderZ.value = 0;
                        Lamp1.GetComponent<LampControl>().startingRotationx = Lamp1.GetComponent<Transform>().rotation.eulerAngles.x - 360.0f;
                        Lamp1.GetComponent<LampControl>().startingRotationy = Lamp1.GetComponent<Transform>().rotation.eulerAngles.y - 360.0f;
                        Lamp1.GetComponent<LampControl>().startingRotationz = Lamp1.GetComponent<Transform>().rotation.eulerAngles.z - 360.0f;
                        //Debug.Log(Lamp1.transform.GetChild(0).GetComponent<Light>().intensity);
                        intensity.value = Lamp1.transform.GetChild(0).GetComponent<Light>().intensity;
                        range.value = Lamp1.transform.GetChild(0).GetComponent<Light>().range;
                    }
                    else if (hitInfo.transform.gameObject.name == "Lampa Druga")
                    {
                        
                        Lamp1.GetComponent<LampControl>().thisLamp = false;
                        Lamp2.GetComponent<LampControl>().thisLamp = true;
                        Lamp3.GetComponent<LampControl>().thisLamp = false;
                        sliderX.value = 0;
                        sliderY.value = 0;
                        sliderZ.value = 0;
                        Lamp2.GetComponent<LampControl>().startingRotationx = Lamp2.GetComponent<Transform>().rotation.eulerAngles.x - 360.0f;
                        Lamp2.GetComponent<LampControl>().startingRotationy = Lamp2.GetComponent<Transform>().rotation.eulerAngles.y - 360.0f;
                        Lamp2.GetComponent<LampControl>().startingRotationz = Lamp2.GetComponent<Transform>().rotation.eulerAngles.z - 360.0f;
                        intensity.value = Lamp2.transform.GetChild(0).GetComponent<Light>().intensity;
                        range.value = Lamp2.transform.GetChild(0).GetComponent<Light>().range;
                    }
                    else if (hitInfo.transform.gameObject.name == "Lampa Trzecia")
                    {
                        
                        Lamp1.GetComponent<LampControl>().thisLamp = false;
                        Lamp2.GetComponent<LampControl>().thisLamp = false;
                        Lamp3.GetComponent<LampControl>().thisLamp = true;
                        sliderX.value = 0;
                        sliderY.value = 0;
                        sliderZ.value = 0;
                        Lamp3.GetComponent<LampControl>().startingRotationx = Lamp3.GetComponent<Transform>().rotation.eulerAngles.x - 360.0f;
                        Lamp3.GetComponent<LampControl>().startingRotationy = Lamp3.GetComponent<Transform>().rotation.eulerAngles.y - 360.0f;
                        Lamp3.GetComponent<LampControl>().startingRotationz = Lamp3.GetComponent<Transform>().rotation.eulerAngles.z - 360.0f;
                        intensity.value = Lamp3.transform.GetChild(0).GetComponent<Light>().intensity;
                        range.value = Lamp3.transform.GetChild(0).GetComponent<Light>().range;
                    }
                }
                else
                {
                    //Debug.Log("nopz");
                }
            }
            else
            {
               // Debug.Log("No hit");
            }
            
        }
    }

    public void exitEdit()
    {
        camera.GetComponent<CameraMover>().enabled = true;
        Lamp1.GetComponent<LampControl>().thisLamp = false;
        Lamp2.GetComponent<LampControl>().thisLamp = false;
        Lamp3.GetComponent<LampControl>().thisLamp = false;
        sliderX.value = 0;
        sliderY.value = 0;
        sliderZ.value = 0;
        GUI.SetActive(false);
    }
}
