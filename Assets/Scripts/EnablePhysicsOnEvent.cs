using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePhysicsOnEvent : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        UIButtonHandler.OnUIStartButtonClicked += StartGravityOnButtonClicked;
        rb.isKinematic = true;
    }

    private void StartGravityOnButtonClicked()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    private void OnDestroy()
    {
        UIButtonHandler.OnUIStartButtonClicked -= StartGravityOnButtonClicked;
    }
}
