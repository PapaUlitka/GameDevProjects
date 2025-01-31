using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeRemaining = 0.09f;
    private float timer;

    private void Start()
    {
        timer = timeRemaining;
    }
    // Update is called once per frame

    void Update()
    {
        // On spacebar press, send dog

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeRemaining;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }

    }
}
