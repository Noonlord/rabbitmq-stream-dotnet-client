﻿// This source code is dual-licensed under the Apache License, version
// 2.0, and the Mozilla Public License, version 2.0.
// Copyright (c) 2007-2023 VMware, Inc.

namespace RabbitMQ.Stream.Client;

public abstract class Info
{
    public string Stream { get; }
    public string ClientProvidedName { get; }

    protected Info(string stream, string clientProvidedName)
    {
        Stream = stream;
        ClientProvidedName = clientProvidedName;
    }
}
