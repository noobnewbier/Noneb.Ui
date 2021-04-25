using System;
using Noneb.Ui.Runtime.Core.Input.Event;

namespace Noneb.Ui.Runtime.Core.Input
{
    public interface IInputSystem
    {
        event NEventHandler<AnyInput> AnyInput;
    }
}