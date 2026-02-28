using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int numberOfCakes {get; private set;}

    public void CakeCollected() 
    {
        numberOfCakes++;
        Debug.Log("Cakes Collected: " + numberOfCakes);
    }
}
