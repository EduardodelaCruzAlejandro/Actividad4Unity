using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{

    public PlayerInteract PlayerActions;
    private InputAction click;
    public GameObject arrowPrefab;

    private void Awake()
    {
          PlayerActions = new PlayerInteract();
    }

    private void OnEnable()
    {
        click = PlayerActions.Player.Click;
        click.Enable();
        click.performed += Interact;
    }

    private void OnDisable()
    {
        click.Disable();
    }


    private void Interact(InputAction.CallbackContext context)
    {
        Instantiate(arrowPrefab, transform.position, Quaternion.identity);

    }



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
