using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    public GameObject popupPanel;
    private bool isPlayerInRange = false;
    private bool popupOpened = false;
    private CharacterMovement playerMovement;

    private void Start()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>();
    }

    void Update()
    {
        if (isPlayerInRange && !popupOpened)
        {
            OpenPopup();
            popupOpened = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entro OnTriggerEnter2D.");
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            popupOpened = false;
        }
    }

    private void OpenPopup()
    {
        popupPanel.SetActive(true);
        playerMovement.isMoventEnable = false;
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
        playerMovement.isMoventEnable = true;
    }

}
