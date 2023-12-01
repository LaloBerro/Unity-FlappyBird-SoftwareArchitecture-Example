using MechanicsObstaclesGenerator.Timer.Domain;

namespace SwitcherChangers.Domain
{
    public class SwitcherChanger
    {
        private readonly ISwitcher _switcher;
        private readonly bool _hasToTurnOn;

        public SwitcherChanger(ISwitcher switcher, bool hasToTurnOn)
        {
            _switcher = switcher;
            _hasToTurnOn = hasToTurnOn;
        }

        public void TurnSwitcher()
        {
            if (_hasToTurnOn)
                _switcher.TurnOn();
            else
                _switcher.TurnOff();
        }
    }
}