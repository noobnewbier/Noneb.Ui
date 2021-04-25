using Noneb.Ui.Runtime.Core.Input.Event;

namespace Noneb.Ui.Runtime.Core.Input
{
    public class NonebInputSystem : IInputSystem
    {
        public void Update()
        {
            if (UnityEngine.Input.anyKey)
            {
                AnyInput?.Invoke(Event.AnyInput.Instance);
            }
        }

        public event NEventHandler<AnyInput> AnyInput;
    }
}