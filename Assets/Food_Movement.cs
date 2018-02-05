using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Food_Movement : MonoBehaviour {

    float speed = 9.0f;
    Vector3 target = new Vector3(0, 0, -2);
    //int afterOrigin = 0;
    bool gameOver;
    public Text gameOverText;
    float frenzyTimer;
    bool inputOver;    


    // Use this for initialization
    void Start () {
        gameOver = false;
        gameOverText.text = "";
        inputOver = false;
        //inputTimer = 1.2f;
        
	}
	
	// Update is called once per frame
	void Update () {

        float step = speed * Time.deltaTime;

        if (transform.position.x == 0.0)
        {
            target = new Vector3(-10, 0, -2);
            WaitForInput();

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }
    }

    IEnumerator WaitForInput()
    {
        while(true)
        {
            Debug.Log("Test");
            yield return new WaitForSeconds(1.2f);
            if(Input.GetMouseButtonDown(0))
            {
                gameOver = true;
            }
            if (gameOver)
            {
                gameOverText.text = "You Win!";
            }
            yield return null;
        }
    }
}
