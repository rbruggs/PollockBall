using Es.InkPainter;
using Es.InkPainter.Sample;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onPickUp : MonoBehaviour
{
    [SerializeField]
    GameObject playerObject;
    private GameObject gameManager;
    private Color capColor;
    Renderer playerRenderer;
    

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("Player");
        gameManager = GameObject.Find("GameManager");        
        capColor = new Color(
        Random.Range(0f, 1f),
        Random.Range(0f, 1f),
        Random.Range(0f, 1f)
        );

        var capRenderer = this.GetComponent<Renderer>();
        capRenderer.material.SetColor("_Color", capColor);
        playerRenderer = playerObject.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT CAP");

        playerRenderer.material.SetColor("_Color", capColor);
        playerObject.GetComponent<CollisionPainter>().brush.Color = capColor;
        gameManager.GetComponent<Spawner>().SpawnObj();
        playerObject.GetComponent<timeTrigger>().addGameTime();
        Destroy(this.gameObject);

    }
}

