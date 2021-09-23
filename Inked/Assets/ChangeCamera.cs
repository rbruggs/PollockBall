using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField]
     Camera cam1;
    [SerializeField]
     Camera cam2;
    bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    public void Togglecam()
    {
        if (!gameOver)
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
            gameOver = true;
        }
    }
    
}
