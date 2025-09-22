public class TurnLeft : Command
{
    private PlayerMovement _controller;

    public TurnLeft(PlayerMovement playerMovement)
    {
        _controller = playerMovement;
    }

    public void Execute()
    {
        _controller.Left();
    }
}
