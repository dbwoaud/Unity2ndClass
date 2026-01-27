public interface IRewardable
{
    public void Receive();
}

public interface IStatable
{
    public void Enter(Character character);
    public void Stay(Character character);
    public void Exit(Character character);

}
