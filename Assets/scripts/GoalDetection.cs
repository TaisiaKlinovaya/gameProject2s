using UnityEngine;

public class GoalDetection : MonoBehaviour
{
    // Diese Methode wird aufgerufen, wenn ein anderes Objekt den Trigger betritt.
    private void OnTriggerEnter(Collider other)
    {
        // �berpr�fen, ob das Objekt, das den Trigger betritt, der Ball ist.
        if (other.CompareTag("Ball"))
        {
            // Wenn ja, wird eine Nachricht in die Konsole ausgegeben.
            Debug.Log("Tor! Der Ball ist im Tor.");
            // Hier kannst du deine Logik hinzuf�gen, z.B. das Spiel zu stoppen oder Punkte zu vergeben.
        }
    }
}
