﻿using Adapter.Interface;
using Adapter.Model;

Adaptee adaptee = new Adaptee();
ITarget target = new Adapterr(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());