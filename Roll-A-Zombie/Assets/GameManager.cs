using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{

    private int selectedZombiePosition;
    private int score = 0;
    public Text scoreText;
    public GameObject selectedZombie;
    public List<GameObject> zombies;
    public Vector3  selectedSize;
    public Vector3 defaultSize;

    // Start is called before the first frame update
    void Start(){
      SelectZombie(selectedZombie);
      scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update(){

      if (Input.GetKeyDown("left")){
        getZombieLeft();
      }

      if (Input.GetKeyDown("right")){
        getZombieRight();
      }

      if (Input.GetKeyDown("up")){
        PushUp();
      }
    }

    void getZombieLeft()
    {
      if (selectedZombiePosition == 0){
        SelectZombie (zombies[3]);
        selectedZombiePosition = 3;
      }else {
        GameObject newZombie = zombies[selectedZombiePosition - 1];
        SelectZombie (newZombie);
        selectedZombiePosition = selectedZombiePosition - 1;
      }
    }

    void getZombieRight(){
      if (selectedZombiePosition == 3){
        SelectZombie (zombies[0]);
        selectedZombiePosition = 0;
      } else {
        GameObject newZombie = zombies[selectedZombiePosition + 1];
        SelectZombie (newZombie);
        selectedZombiePosition = selectedZombiePosition + 1;

      }
    }

    void SelectZombie(GameObject newZombie){
      selectedZombie.transform.localScale = defaultSize;
      selectedZombie = newZombie;
      newZombie.transform.localScale = selectedSize;
    }

    void PushUp(){
      Rigidbody rb  = selectedZombie.GetComponent<Rigidbody>();
      rb.AddForce(0,0,10, ForceMode.Impulse);
    }

    public void AddPoint(){
      score = score + 1;
      scoreText.text = "Score: " + score;
    }
  }
