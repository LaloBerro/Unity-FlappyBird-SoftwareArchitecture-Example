namespace Jump.Domain
{
    public class Jumper
    {
        private readonly IForcer _forcer;
        private float _forceAmount;

        public Jumper(IForcer forcer, float forceAmount)
        {
            _forcer = forcer;
            _forceAmount = forceAmount;
        }

        public void SetForceAmount(float forceAmount)
        {
            _forceAmount = forceAmount;
        }

        public void Jump()
        {
            _forcer.AddForce(_forceAmount);
        }
    }
}