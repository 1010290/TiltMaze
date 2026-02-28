using UnityEngine;

public class CakeScript : MonoBehaviour
{
    public PointManagerScript pointManagerScript;

    private void OnTriggerEnter(Collider other) 
    {
        PlayerScript playerScript = other.GetComponent<PlayerScript>();
        
        if (playerScript != null) 
        {
            playerScript.CakeCollected();
            gameObject.SetActive(false);
            pointManagerScript.UpdateScore();
        }
    }
}
