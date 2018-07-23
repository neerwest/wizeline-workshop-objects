using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNear : MonoBehaviour {

    public Transform cube;
    public Transform sphere;

    [SerializeField]
    private float minDistance = 5;

    private Renderer rend;

	// Use this for initialization
	void Start () {
        //Fetch the Renderer from the GameObject
        rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", Color.green);
	}
	
	// Update is called once per frame
	void Update () {
        float cubeDistance = Vector3.Distance(cube.position, transform.position);
        float sphereDistance = Vector3.Distance(sphere.position, transform.position);

        if ( cubeDistance  < minDistance ) {
            //rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.red);
        }

        if (sphereDistance < minDistance)
        {
            //rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.blue);
        }

        if ( sphereDistance < minDistance && cubeDistance < minDistance ){
            rend.material.SetColor("_Color", Color.magenta);
        }

        if (sphereDistance > minDistance && cubeDistance > minDistance)
        { 
            rend.material.SetColor("_Color", Color.green);
        }

	}
}
