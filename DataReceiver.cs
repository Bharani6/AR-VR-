
using System;
using System.Text;
using WebSocketSharp;
using UnityEngine;
using UnityEngine.UI;

public class DataReceiver : MonoBehaviour
{
    private WebSocket ws;
    public Text speedText;
    public Text ecoScoreText;

    void Start()
    {
        ws = new WebSocket("ws://localhost:8080");
        ws.OnMessage += OnMessageReceived;
        ws.Connect();
    }

    void OnMessageReceived(object sender, MessageEventArgs e)
    {
        var data = JsonUtility.FromJson<VehicleData>(e.Data);
        speedText.text = "Speed: " + data.speed.ToString("F1") + " km/h";
        ecoScoreText.text = "Eco Score: " + data.ecoScore.ToString("F0") + "/100";
    }

    [Serializable]
    public class VehicleData
    {
        public float speed;
        public float ecoScore;
    }

    void OnDestroy()
    {
        ws.Close();
    }
}
