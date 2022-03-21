using UnityEngine;
using System.Collections;

public class movemement : MonoBehaviour {
    public GameObject Shpere_boy;
    public GameObject Shpere_dance;
    public GameObject Shpere_run;
    public GameObject Shpere_sit;
    public GameObject boy;
    public GameObject Running;
    public GameObject Dancing;
    public GameObject Sitting;
    private float distance_dance;
    private float distance_run;
    private float distance_sit;

    // Use this for initialization
    void Start () {
        boy.SetActive(true);
        Running.SetActive(false);
        Dancing.SetActive(false);
        Sitting.SetActive(false);
    }
    
    
    // Update is called once per frame
    void Update () {
        
        //dance move
        if((Shpere_dance.GetComponent<Renderer>()).isVisible){
            distance_dance = Vector3.Distance(Shpere_boy.transform.position, Shpere_dance.transform.position);
            Debug.Log(distance_dance);
            if((Shpere_boy.GetComponent<Renderer>()).isVisible & distance_dance<0.03){
                Debug.Log("dance");
                boy.SetActive(false);
                Dancing.SetActive(true);
                Running.SetActive(false);
                Sitting.SetActive(false);
            }else if((Shpere_boy.GetComponent<Renderer>()).isVisible & distance_dance>0.03){
                Debug.Log("no dance 1");
                Dancing.SetActive(false);
                boy.SetActive(true);
                Running.SetActive(false);
                Sitting.SetActive(false);
            }

        //run_move
        }else if((Shpere_run.GetComponent<Renderer>()).isVisible){
            distance_run = Vector3.Distance(Shpere_boy.transform.position, Shpere_run.transform.position);
            if((Shpere_boy.GetComponent<Renderer>()).isVisible & distance_run<0.03){
                boy.SetActive(false);
                Running.SetActive(true);
                Dancing.SetActive(false);
                Sitting.SetActive(false);
            }else if((Shpere_boy.GetComponent<Renderer>()).isVisible & distance_run>0.03){
                Running.SetActive(false);
                boy.SetActive(true);
                Dancing.SetActive(false);
                Sitting.SetActive(false);
            }

        //sit_move
        }else if((Shpere_sit.GetComponent<Renderer>()).isVisible){
            distance_sit = Vector3.Distance(Shpere_boy.transform.position, Shpere_sit.transform.position);
            if((Shpere_boy.GetComponent<Renderer>()).isVisible & distance_sit<0.03){
                boy.SetActive(false);
                Sitting.SetActive(true);
                Running.SetActive(false);
                Dancing.SetActive(false);
                
            }else if((Shpere_boy.GetComponent<Renderer>()).isVisible & distance_sit>0.03){
                Sitting.SetActive(false);
                boy.SetActive(true);
                Running.SetActive(false);
                Dancing.SetActive(false);
            }
        }else{
            Sitting.SetActive(false);
            boy.SetActive(true);
            Running.SetActive(false);
            Dancing.SetActive(false);
        }
    }
}
///
            
        
/////