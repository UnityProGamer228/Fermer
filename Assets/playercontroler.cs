using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playercontroler : MonoBehaviour
{
  private float speed=10;
  private float vertical;
  private float horizontal;
  private int zRange=8;
private int xRange=15;
public GameObject banana;
public GameObject sandwich;
private GameManager GM;
    
    // Start is called before the first frame update
    void Start()
    {
        GM=GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
      vertical=Input.GetAxis("Vertical");
      horizontal=Input.GetAxis("Horizontal");
      if( !GM.GameOver)
    {
       transform.Translate(Vector3.forward*Time.deltaTime*speed*vertical);
      transform.Translate(Vector3.right*Time.deltaTime*speed*horizontal);
    }
      

      if(transform.position.z>zRange)
      {
        transform.position=new Vector3(transform.position.x,transform.position.y,zRange);
      }
if(transform.position.z<-zRange)
      {
        transform.position=new Vector3(transform.position.x,transform.position.y,-zRange);
      }
   if(transform.position.x>xRange)
      {
        transform.position=new Vector3(xRange,transform.position.y,transform.position.z);
      }
if(transform.position.x<-xRange)
      {
        transform.position=new Vector3(-xRange,transform.position.y,transform.position.z);
      }

      if(Input.GetKeyDown(KeyCode.Mouse0) && !GM.GameOver)
    {
      Instantiate(banana,transform.position,banana.transform.rotation);
    }
   if(Input.GetKeyDown(KeyCode.Mouse1) && !GM.GameOver )
    {
      Instantiate(sandwich,transform.position,sandwich.transform.rotation);
    }
  
    }
void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag=="Animals")
    {              
    GM.minusScore(5); 
    Destroy(other.gameObject);
    }
  }

}
