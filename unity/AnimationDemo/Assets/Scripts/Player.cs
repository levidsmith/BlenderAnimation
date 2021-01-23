//2020 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    float fCountdown;
    float fMaxCountdown;
    bool isWalking;
    public GameObject model;

    void Start() {
        fMaxCountdown = 2f;
        fCountdown = fMaxCountdown;
        isWalking = false;
        
    }

    void Update() {
        fCountdown -= Time.deltaTime;
        if (fCountdown <= 0f) {
            changeAnimation();
            fCountdown += fMaxCountdown;
        }
    }

    private void changeAnimation() {
        isWalking = !isWalking;
        if (isWalking) {
            model.GetComponent<Animation>().Play("Armature|Walking");
        } else {
            model.GetComponent<Animation>().Play("Armature|Standing");
        }

    }
}