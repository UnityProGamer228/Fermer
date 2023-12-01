using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
{
   private float speed=6;
 private GameManager GM;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GM=GameObject.Find("GameManager").GetComponent<GameManager>();
    
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector3.forward*Time.deltaTime*speed);   
    }
  void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag=="Animals")
    {              
     Destroy(gameObject);
     Destroy(other.gameObject);
     GM.IncreaseScore(1); 
    }
  }

}

