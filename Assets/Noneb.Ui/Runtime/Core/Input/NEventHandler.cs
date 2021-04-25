using System;
using Noneb.Ui.Runtime.Core.Input.Event;

namespace Noneb.Ui.Runtime.Core.Input
{
    public delegate void NEventHandler<in TArg>(TArg arg) where TArg : InputEvent;
}