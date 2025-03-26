using jdkore.helpers;

namespace CastleDefender
{
    public class Engine : Initializable
    {
        private readonly OOECS.system.Engine _systemEngine = OOECS.system.Engine.Instance;
        
        public override void Initialize()
        {
        }

        private void Update()
        {
            _systemEngine.Tick();
        }
    }
}