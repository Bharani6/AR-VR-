
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Text speedText;
    public Text ecoScoreText;
    public Image navigationArrow;

    void Update()
    {
        float speed = GetVehicleSpeed(); // Replace with actual speed data
        float ecoScore = CalculateEcoScore(); // Replace with real eco-driving score logic

        speedText.text = "Speed: " + speed.ToString("F1") + " km/h";
        ecoScoreText.text = "Eco Score: " + ecoScore.ToString("F0") + "/100";
        UpdateNavigationArrow(); // function to update the navigation direction
    }

    float GetVehicleSpeed() 
    {
        // Mock data - in a real application, connect to vehicle's speed sensor
        return 60.0f;
    }

    float CalculateEcoScore() 
    {
        // Mock eco-score logic
        return Random.Range(70, 100);
    }

    void UpdateNavigationArrow() 
    {
        // Update the navigation arrow image or rotate based on direction
        navigationArrow.transform.rotation = Quaternion.Euler(0, 0, 30); // Example
    }
}
