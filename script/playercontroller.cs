using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{
    public ParticleSystem explode;
    public AudioClip bomb;
    public AudioSource collidesound;
    public float speed;
    public Button restart;
    public Text score;
    public float counter;
    public collisiondetection colisiondet;
     public GameObject playerbulletprefab;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1;
        restart.gameObject.SetActive(false);
        //   collidesound=GetComponent<AudioSource>();
    
    }

    // Update is called once per frame
    void Update()
    {
            score.text="Scoreee :"+colisiondet.counter;
        var Horizontal=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Horizontal*Time.deltaTime*speed);
        if(transform.position.x<=-5.5f){
            transform.position=new Vector3(-5.5f,transform.position.y,transform.position.z);
            Debug.Log(playerbulletprefab.transform.rotation);
        }
        if(transform.position.x>=5.5f){
            transform.position=new Vector3(5.5f,transform.position.y,transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.F)){
            Instantiate(playerbulletprefab,new Vector3(transform.position.x,transform.position.y+1,transform.position.z),Quaternion.identity);
        }
    }
    public void OnCollisionEnter(Collision col){
        if(col.transform.tag=="enemy" || col.transform.tag=="enem"){
            Debug.Log("Play sound");
            Debug.Log(bomb);
            explode.Play();
            collidesound.PlayOneShot (bomb);
            restart.gameObject.SetActive(true);
            Destroy(col.gameObject);
          //  Time.timeScale=0;
            

             //collidesound.PlayOneShot(bomb,1.0f);
            //Destroy(gameObject);
            //Destroy(col.gameObject);
           
        }
       
    }
}
