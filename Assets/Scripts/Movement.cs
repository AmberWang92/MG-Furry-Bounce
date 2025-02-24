using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    // [SerializeField] private KillTrigger publisher;
    [SerializeField] private InputActionReference movementAction;
    private float movementSpeed = 5f;

    private Vector2 startPosition;
    private Quaternion startRotation;
    private Vector2 startScale;




    // private void Awake()
    // {
    //     publisher.resetPlayerEvent.AddListener(ResetPlayerTransform);
    // }

    // private void OnDestroy()
    // {
    //     publisher.resetPlayerEvent.RemoveListener(ResetPlayerTransform);
    // }

    // Start is called before the first frame update
    void Start()
    {
        // Save original transform values
        startPosition = transform.position;
        startRotation = transform.rotation;
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDirection = movementAction.action.ReadValue<Vector2>();
        transform.Translate(moveDirection * movementSpeed * Time.deltaTime);
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
    }

    public void ResetPlayerTransform()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
        transform.localScale = startScale;
    }
    public void PlayerScaleSmaller()
    {
        transform.localScale = startScale * 0.7f;
    }

}
