using UnityEngine;
using UnityEngine.Events;

public class SmallerTrigger : MonoBehaviour
{

    [SerializeField] private GameObject playerObject;

    void Start()
    {
        // mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == playerObject)
        {
            playerObject.GetComponent<Movement>().PlayerScaleSmaller();
            gameObject.SetActive(false);
        }
    }

}
