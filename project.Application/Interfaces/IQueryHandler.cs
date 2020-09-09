using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Application.Interfaces
{
    public interface IQueryHandler<TQuery,TResult> where TQuery:IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}
