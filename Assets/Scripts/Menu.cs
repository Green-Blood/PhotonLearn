using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [Header("Screens")] 
    public GameObject mainScreen;
    public GameObject lobbyScreen;

    [Header("Main Screen")] 
    public Button createRoomButton;
    public Button joinRoomButton;

    [Header("Lobby Screen")]
    public TextMeshProUGUI playerListText;

}
