using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Movement : MonoBehaviour {

    float speed = 9.0f;
    Vector3 target = new Vector3(0, 0, -2);
    int afterOrigin = 0;
    bool listenForMouse = false;

    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x == 0.0)
        {
            target = new Vector3(-10, 0, -2);
            afterOrigin = 1;
            StartCoroutine(WaitASec());
        }

        if (afterOrigin != 1)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }

    }

    public IEnumerator WaitASec()
    {
        listenForMouse = true;

        

        yield return new WaitForSeconds(1.2f);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    private void OnMouseDown()
    {
        if(listenForMouse)
        {

        }
    }

}
