using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageShow : MonoBehaviour {
    public bool ShowImage;
    public GameObject Map;


    void Update()
    {
        if (Input.GetButtonDown("Jump") && ShowImage == false)
        {
            Map.SetActive(true);
            ShowImage = true;
        }
        else if (Input.GetButtonDown("Jump") && ShowImage == true) {
            Map.SetActive(false);
            ShowImage = false;
        }
    }
}
