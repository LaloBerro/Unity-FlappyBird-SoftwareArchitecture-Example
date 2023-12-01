namespace Jump.Freezers.Domain
{
    public interface IFreezableObject
    {
        void Freeze();
        void UnFreeze();
    }
}