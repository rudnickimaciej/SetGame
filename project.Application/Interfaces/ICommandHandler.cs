﻿using System;
using System.Collections.Generic;
using System.Text;

namespace project.Application.Interfaces
{
    public interface ICommandHandler<TCommand> where TCommand:ICommand
    {
        void Handle(TCommand command);
    }
}
