using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    [SerializeField] float carSpeed = 1f;
    [SerializeField] float carAcceleration = 2f;
    [SerializeField] float carTurnSpeed = 10f;

    private int steerValue;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProcessMove();
        ProcessTurn();
    }

    void ProcessMove()
    {

        carSpeed += carAcceleration * Time.deltaTime;
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);
    }

    void ProcessTurn()
    {
        transform.Rotate(0f, steerValue * carTurnSpeed * Time.deltaTime, 0);
    }

    public void Steer(int value)
    {
        steerValue = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
