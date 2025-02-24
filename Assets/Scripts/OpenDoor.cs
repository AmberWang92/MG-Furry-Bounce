using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject door;


    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == playerObject)
        {
            gameObject.SetActive(false);

            door.transform.position += new Vector3(0.0f, 1.0f, 0.0f);
        }
    }
}
