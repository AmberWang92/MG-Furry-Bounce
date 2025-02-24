using UnityEngine;
using UnityEngine.Events;
public class KillTrigger : MonoBehaviour
{
    // Our events
    public UnityEvent resetPlayerEvent;

    // [SerializeField] private GameObject playerObject;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            resetPlayerEvent.Invoke();
            // playerObject.GetComponent<Movement>().ResetPlayerTransform();
        }
    }
}
