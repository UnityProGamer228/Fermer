using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnanimals : MonoBehaviour
{
 public GameObject[] animals;
 private int animalsIndex;
 private Vector3 randomPosition;
 private GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
      GM=GameObject.Find("GameManager").GetComponent<GameManager>();  
       InvokeRepeating("spawn",2,2); 
    }

    // Update is called once per frame
    void Update()
    {
        
         
    
    }
void spawn()
{

if(!GM.GameOver)
{
   animalsIndex=Random.Range(0,animals.Length);
randomPosition=new Vector3(Random.Range(-15,15),0,11);
Instantiate(animals[animalsIndex],randomPosition,animals[animalsIndex].transform.rotation);
}

}




}

