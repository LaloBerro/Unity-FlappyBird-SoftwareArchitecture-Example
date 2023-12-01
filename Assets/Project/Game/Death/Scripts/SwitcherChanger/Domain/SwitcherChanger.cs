using MechanicsObstaclesGenerator.Timer.Domain;

namespace SwitcherChangers.Domain
{
    public class SwitcherChanger
    {
        private readonly ISwitcher _switcher;
        private bool _isTurnOn;

        public SwitcherChanger(ISwitcher switcher, bool isTurnOn)
        {
            _switcher = switcher;
            _isTurnOn = isTurnOn;
        }

        public void TurnSwitcher()
        {
            _isTurnOn = !_isTurnOn;
            
            if (_isTurnOn)
                _switcher.TurnOn();
            else
                _switcher.TurnOff();
        }
    }
}