using UnityEngine;

public class ScremTriggerOne : MonoBehaviour
{
    [SerializeField] private GameObject _broad;
    [SerializeField] private GameObject _broad2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _broad.SetActive(true);
            _broad2.SetActive(false);
        }
    }
}
