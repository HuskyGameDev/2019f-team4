using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Right now the image will disapear on click

//I tried to switch the showimage trues and false so the image would appear 
//on the click, but for some reason it wasn't working. Might be from my end.

//I connected the image by adding a component under MainCam. Just like compass.

public class ImageShow : MonoBehaviour {
    public bool ShowImage;
    public Image MapImage;

    void Start()
    {
        MapImage.enabled = true;
        ShowImage = true;
    }

    void Update()
    {
        if (Input //Add the click function  )      When I tried testing I used  ".GetKeyDown("g")"  When g on your keyboard is clicked the image will appear and disappear
        {
            if (ShowImage == true) {
                MapImage.enabled = true;
                ShowImage = false;
            }
            else {
                MapImage.enabled = true;
                ShowImage = true;
            }
        }
    }
}
