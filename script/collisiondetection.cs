using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisiondetection : MonoBehaviour
{
    private GameObject ball;
    private Text Score;
    public  float counter=0;
    // Start is called before the first frame update
    void Start()
    {
        ball=GameObject.Find("secsphere");
        Score=(Text)FindObjectOfType(typeof(Text));
        //Text Score = (Text)FindObjectOfType(typeof(Text));
        Score.text="Score :"+counter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="enemy"){
         Vector3 pos=transform.position;
        Destroy(gameObject);
        Destroy(col.gameObject);
        Instantiate(ball,new Vector3(transform.position.x+1,transform.position.y,transform.position.z),ball.transform.rotation);
          Instantiate(ball,new Vector3(transform.position.x-1,transform.position.y,transform.position.z),ball.transform.rotation);
        Debug.Log(ball.name);
        }
        if(col.transform.tag=="enem"){
            Destroy(gameObject);
            Destroy(col.gameObject);
            counter+=1;
            Score.text="Scoreo :"+counter;
        }
        
    }
}
