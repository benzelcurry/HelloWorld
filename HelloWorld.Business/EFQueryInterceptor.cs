using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Data.Common;
using System.Diagnostics;

namespace HelloWorld.Business;

public class EFQueryInterceptor: DbCommandInterceptor
{
    public override InterceptionResult<DbDataReader> ReaderExecuting(
        DbCommand command,
        CommandEventData eventData,
        InterceptionResult<DbDataReader> result)
    {
        Debug.WriteLine($"Executing Query {command.CommandText}");

        return result;
    }
}
