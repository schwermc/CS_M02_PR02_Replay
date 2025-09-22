public class TurnRight : Command
{
    private PlayerMovement _controller;

    public TurnRight(PlayerMovement playerMovement)
    {
        _controller = playerMovement;
    }

    public void Execute()
    {
        _controller.Right();
    }
}