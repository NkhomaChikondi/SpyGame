using Microsoft.Extensions.DependencyInjection;
using SpyGame.Interfaces;
using SpyGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            // register dependencies
            var serviceProvider = new ServiceCollection().AddSingleton<IDataManager, DataMangerService>().BuildServiceProvider();
            var VerseProvider = new ServiceCollection().AddSingleton<IEncodeMessage, EncodeMessageService>().BuildServiceProvider();

            // Resolve dependencies
            var dataService = serviceProvider.GetRequiredService<IDataManager>();
            var encodingService = VerseProvider.GetRequiredService<IEncodeMessage>();

            var MessageFile = dataService.GetFile(args);
            // pass the message to the encoding function
            encodingService.Encoding(MessageFile);
        }
    }
}
