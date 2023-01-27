using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace _koh
{
    class MainClass
    {
        const long ClientId = 1065927278527270922;
        const string BotToken = "MTA2NTkyNzI3OD UyNzI3MDkyMg.Gz65ws.Phk20AsNW6m5qztj5ctsoO6Vser4ODraOOBFcY";
        

        static async Task Main()
        {
            var client = new DiscordSocketClient();
            client.MessageReceived += Cilent_MessageReceived;

            await client.LoginAsync(TokenType.Bot, BotToken);
            await client.StartAsync();

            Console.ReadLine();
             
        }
        static async Task Cilent_MessageReceived(SocketMessage arg)
        {
            if (arg.Author.Id != ClientId)
            {
                //Console. WriteLine("Received");
                //Console.WriteLine("Arg_: " + arg.Author.Username);
                //Console.WriteLine( "Content: " + arg.Content);
                await arg.Channel.SendMessageAsync(arg.Author.Username + "さん" + arg.Content + "と言いましたね!!");
                

            }
        }
        //test
        //static async Task Cilent_MessageReceived(SocketMessage arg)
        //{
        //    if (arg.Content == "今日の運勢は？")
        //    {
        //        Random i = new Random();
        //        int randomValue = i.Next(100);

        //        if(randomValue == 0)
        //        {
        //            await arg.Channel.SendMessageAsync(arg.Author.Username + "さんの今日の運勢は、大吉です。");
        //        }
        //        else if(randomValue < 10)
        //        {
        //            await arg.Channel.SendMessageAsync(arg.Author.Username + "さんの今日の運勢は、中吉です。");
        //        }
        //        else if(randomValue < 40)
        //        {
        //            await arg.Channel.SendMessageAsync(arg.Author.Username + "さんの今日の運勢は、小吉です。");
        //        }
        //        else if(randomValue < 90)
        //        {
        //            await arg.Channel.SendMessageAsync(arg.Author.Username + "さんの今日の運勢は、末吉です。");
        //        }
        //        else if(randomValue < 100)
        //        {
        //            await arg.Channel.SendMessageAsync(arg.Author.Username + "さんの今日の運勢は、凶です。");
        //        }

        //    }

        //}
    }
}
