using MechanicsObstaclesGenerator.Timer.Domain;
using SwitcherChangers.Domain;
using UnityEngine;
using Zenject;
using ZenjectExtensions.Zinstallers;

namespace SwitcherChangers.Installers
{
    public class SwitcherChangerZinstaller : InstanceZinstaller<SwitcherChanger>
    {
        [Header("Config")] [SerializeField] private bool _hasToTurnOn;

        [Inject] private readonly ISwitcher _switcher;

        protected override SwitcherChanger GetInitializedClass()
        {
            return new SwitcherChanger(_switcher, _hasToTurnOn);
        }
    }
}