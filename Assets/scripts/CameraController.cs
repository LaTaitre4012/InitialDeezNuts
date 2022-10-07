using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Player;
    public GameObject child;
    public float speed;
    public Vector3 cameraOffset = new Vector3(0, 2, 0);

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        child = Player.transform.Find("CameraConstraint").gameObject;
    }

    private void FixedUpdate()
    {
        follow();
    }

    private void follow()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, child.transform.position, Time.deltaTime * speed);
        gameObject.transform.LookAt(Player.gameObject.transform.position + cameraOffset);
    }
}