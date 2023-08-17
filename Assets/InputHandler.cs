using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera mainCamera;
    List<GameObject> playerUnits = new List<GameObject>();

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));

        if (!rayHit.collider) return;

        if (rayHit.collider.gameObject.tag == "Playable")
        {
            playerUnits.Add(rayHit.collider.gameObject);
            Object.Destroy(rayHit.collider.gameObject);
        }
        if (playerUnits.Count == 5)
        {
            ChosenUnits();
        }
    }
    public void ChosenUnits()
    {
        Debug.Log(playerUnits[0]);
        Debug.Log(playerUnits[1]);
        Debug.Log(playerUnits[2]);
        Debug.Log(playerUnits[3]);
        Debug.Log(playerUnits[4]);
    }
}
