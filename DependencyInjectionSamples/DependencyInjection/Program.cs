using System;
using System.Security.Authentication.ExtendedProtection;
using AbstractedCommon;
using Abstractions;
using Common;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<IPayrollProcessor, DependencyInjectedPayrollProcessor>();
            services.AddTransient<IPaymentProcessorFactory, DIPaymentProcessingFactory>();
            services.AddTransient<IEmployeeDatabase, EmployeeDatabase>();
            services.AddTransient<ILogger, MyLogger>();
            services.AddTransient<CashPaymentProcessor>();
            services.AddTransient<BankTransferPaymentProcessor>();
            services.AddTransient<ChequePaymentProcessor>();
            services.AddSingleton<IApplicationRoot, ApplicationRoot>();

            var provider = services.BuildServiceProvider(new ServiceProviderOptions
            {
                ValidateOnBuild = true
            });

            var app =(IApplicationRoot) provider.GetService(typeof(IApplicationRoot));
            
            app.Run();
        }
    }

    internal class MyLogger : ILogger
    {
        public void LogMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}