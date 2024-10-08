﻿using Elsa.Activities.Console;
using Elsa.Builders;

namespace ElsaQuickstarts.ConsoleApp.HelloWorld;

public partial class Program
{
    public class HelloWorld : IWorkflow
    {
        public void Build(IWorkflowBuilder builder) => builder.WriteLine("Hello World!");
    }
}
