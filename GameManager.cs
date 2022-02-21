using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject plrblt;
    public GameObject[] balls;
    // Start is called before the first frame update
    void Start()
    {
        plrblt=GameObject.Find("plyrblt");
        InvokeRepeating("SpawnBall",2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBall(){
        var randomball=Random.Range(0,balls.Length);
        Instantiate(balls[randomball],new Vector3(Random.Range(-7,7),0.3f,6),Quaternion.identity);
    }
    public void Restart(){
        Debug.Log(SceneManager.sceneCount);
        SceneManager.LoadScene(0);
    }
}
