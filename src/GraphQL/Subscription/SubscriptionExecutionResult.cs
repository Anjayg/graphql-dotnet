﻿using System;
using System.Collections.Generic;

namespace GraphQL.Subscription
{
    public class SubscriptionExecutionResult : ExecutionResult
    {
        public IDictionary<string, IObservable<ExecutionResult>> Streams { get; set; }
    }
}
