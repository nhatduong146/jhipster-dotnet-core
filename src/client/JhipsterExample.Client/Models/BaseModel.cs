using System;
using System.Collections.Generic;

namespace JhipsterExample.Client.Models;

public class BaseModel<TKey>
{
    public TKey Id { get; set; }
}
