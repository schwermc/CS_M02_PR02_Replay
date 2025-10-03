using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker _invoker;
    private bool _isRecording;
    private bool _isReplaying;
    private PlayerMovement playerMovement;
    private Command _buttonA, _buttonD;

    void Start()
    {
        _invoker = gameObject.AddComponent<Invoker>();
        playerMovement = FindObjectOfType<PlayerMovement>();

        _buttonA = new TurnLeft(playerMovement);
        _buttonD = new TurnRight(playerMovement);

        _isRecording = true;
        _isReplaying = false;
        _invoker.Record();
    }

    void FixedUpdate()
    {
        if (!_isReplaying && _isRecording)
        {
            if (Input.GetKey(KeyCode.A))
                _invoker.ExecuteCommand(_buttonA);

            if (Input.GetKey(KeyCode.D))
                _invoker.ExecuteCommand(_buttonD);
        }
        else
        {
            playerMovement.rb.AddForce(0, 0, playerMovement.forwardForce * Time.deltaTime);
        }
    }

    public void StartReplay()
    {
        _isRecording = false;
        _isReplaying = true;
        _invoker.Replay();
    }
}
