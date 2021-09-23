using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeTrigger : MonoBehaviour
{
    [SerializeField]
    Canvas gameCanvas;

    public void addGameTime()
    {
        gameCanvas.GetComponent<Countdown>().addTime();
    }

}
