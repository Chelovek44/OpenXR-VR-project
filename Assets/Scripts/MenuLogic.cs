using HurricaneVR.TechDemo.Scripts;
using UnityEngine;

public class MenuLogic : MonoBehaviour
{
    [SerializeField] private DemoUIManager menuStatus;
    [SerializeField] private GameObject menu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterController>() && menuStatus.ItemPicked() is false)
        {
            menu.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<CharacterController>())
        {
            menu.SetActive(false);
        }
    }
}