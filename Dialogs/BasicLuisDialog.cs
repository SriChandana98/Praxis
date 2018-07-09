using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace Microsoft.Bot.Sample.LuisBot
{
    // For more information about this template visit http://aka.ms/azurebots-csharp-luis
    [LuisModel("6d4b6a16-99d4-409c-9f90-9f0540f33051", "2d4f38971eb94773bac2465e5b0d6cbf")]
    [Serializable]
    public class BasicLuisDialog : LuisDialog<object>
    {
        //public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(
            //ConfigurationManager.AppSettings["6d4b6a16-99d4-409c-9f90-9f0540f33051"], 
            //ConfigurationManager.AppSettings["2d4f38971eb94773bac2465e5b0d6cbf"], 
            //domain: ConfigurationManager.AppSettings["westus.api.cognitive.microsoft.com"])))
        //{
        //}

        [LuisIntent("Greeting")]
        public async Task GreetingIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisGreeting(context, result);
        }
        
        [LuisIntent("Help")]
        public async Task HelpIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisHelp(context, result);
        }
        
        [LuisIntent("Microsoft")]
        public async Task MicrosoftIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowMSResult(context,result);
        }
        
        [LuisIntent("ThankYou")]
        public async Task ThankyouIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowTYResult(context, result);
        }

        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisNone(context, result);
        }
        [LuisIntent("Deloitte")]
        public async Task DeloitteIntent(IDialogContext context, LuisResult result)
        {
            await this.ShowLuisDeloitte(context, result);
        }

        private async Task ShowLuisDeloitte(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($" What is database normalization?\n link:https://www.geeksforgeeks.org/database-normalization-normal-forms/");
            await context.PostAsync($" What is inheritance?\n link:https://www.adobe.com/devnet/actionscript/learning/oop-concepts/inheritance.html");
            await context.PostAsync($" Difference-between C and Java\n link:https://www.quora.com/Whats-the-main-difference-between-C-and-Java");
            await context.PostAsync($" What are the different layers in Open System Interconnection network layer model?\n link:https://www.geeksforgeeks.org/layers-osi-model/");
            await context.PostAsync($" What are the different functions of each of the layer in TCP/IP model? What are the protocols associated with each layer?\n link:https://www.geeksforgeeks.org/layers-osi-model/");
            await context.PostAsync($" What is Cloud Computing?\n link:https://azure.microsoft.com/en-in/overview/what-is-cloud-computing/");
            await context.PostAsync($" What are features of cloud?\n link:https://www.cloudcomputing-news.net/news/2012/oct/04/top-5-cloud-features-every-exec-should-know/");
            await context.PostAsync($" Abstraction and diff between abstract class and Interface?\n link:https://www.javatpoint.com/difference-between-abstract-class-and-interface");
            await context.PostAsync($" What is diff between procedural oriented language and object oriented language? \n link:https://freefeast.info/general-it-articles/difference-between-procedure-oriented-programming-and-object-oriented-programming-procedure-oriented-programming-vs-object-oriented-programming/");
            await context.PostAsync($" Difference between abstraction and encapsulation ? \n link:https://www.quora.com/What-is-the-difference-between-abstraction-and-encapsulation-2");
        }

        private async Task ShowTYResult(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"It's been a pleasure helping you out. All the best for your interview");
        }

        private async Task ShowMSResult(IDialogContext context, LuisResult result)
        {
            /*await context.PostAsync($"Check if a Binary Tree is BST or not \n link:https://www.geeksforgeeks.org/a-program-to-check-if-a-binary-tree-is-bst-or-not/");
            await context.PostAsync($" Remove duplicates from a string, do it in-place.\n link:https://www.geeksforgeeks.org/remove-duplicates-from-a-given-string/");
            await context.PostAsync($" Given a rotated array which is sorted search for an element in it\n link:https://www.geeksforgeeks.org/search-an-element-in-a-sorted-and-pivoted-array/");
            await context.PostAsync($" Given two linked lists that represent two big numbers (numbers that can not be stored in an int or long long int), write a function that adds the numbers and store the result in a third list.Variations of above question like subtract two numbers or multiply two numbers represented by linked lists.\n link:https://www.geeksforgeeks.org/sum-of-two-linked-lists/");
            await context.PostAsync($" Print last 10 lines of a big file or big string.\n link:https://www.geeksforgeeks.org/print-last-10-lines-of-a-given-file/");
            await context.PostAsync($" Clone a linked list with next and arbitrary (or random) pointer\n link:https://www.geeksforgeeks.org/a-linked-list-with-next-and-arbit-pointer/");
            await context.PostAsync($" Connect nodes at same level.\n link:https://www.geeksforgeeks.org/connect-nodes-at-same-level/");
            await context.PostAsync($" Least common ancestor of a binary tree or a binary search tree\n link:https://www.geeksforgeeks.org/lowest-common-ancestor-binary-tree-set-1/");
            await context.PostAsync($" Run length encoding.\n link:https://www.geeksforgeeks.org/run-length-encoding/");
            await context.PostAsync($" Detect cycle in a linked list.\n link:https://www.geeksforgeeks.org/detect-and-remove-loop-in-a-linked-list/");
            await context.PostAsync($" Given a sorted array of size n. Each element in array is unique and lies from 1 to n+1. Find the missing element. Write code and test cases for the same.\n link:https://www.geeksforgeeks.org/find-a-repeating-and-a-missing-number/");
            await context.PostAsync($" Check if a binary tree is balanced.\n link:https://www.geeksforgeeks.org/how-to-determine-if-a-binary-tree-is-balanced/");
            await context.PostAsync($" Two of the nodes of a BST are swapped.\n link:https://www.geeksforgeeks.org/fix-two-swapped-nodes-of-bst/");
            await context.PostAsync($" Draw a circle without floating point arithmetic.\n link:https://www.geeksforgeeks.org/draw-circle-without-floating-point-arithmetic/");
            await context.PostAsync($" Convert a Binary tree to DLL\n link:https://www.geeksforgeeks.org/convert-a-given-binary-tree-to-doubly-linked-list-set-4/");
            await context.PostAsync($" Roof to leaf path sum \n link:https://www.geeksforgeeks.org/root-to-leaf-path-sum-equal-to-a-given-number/");
            await context.PostAsync($" Level order traversal \n link:https://www.geeksforgeeks.org/level-order-tree-traversal/");*/
            var answer = "Roof to leaf path sum equal to a given number;https://www.geeksforgeeks.org/root-to-leaf-path-sum-equal-to-a-given-number/";
            Activity reply = ((Activity)context.Activity).CreateReply();
            var attachment = GetHeroCard(answer);
            reply.Attachments.Add(attachment);
            await context.PostAsync(reply);
        }

        private static Attachment GetHeroCard(string answer)
        {
            string[] a = answer.Split(';');
            string title = a[0];
            string url = a[1];
            HeroCard card = new HeroCard
            {
                Title = title,
            };
            card.Buttons = new List<CardAction>
            {
                new CardAction(ActionTypes.OpenUrl,"Get the solution",value:url)
            };
            return card.ToAttachment();
        }

        private async Task ShowLuisNone(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"Sorry could not process. try 'help' for more");
        }

        private async Task ShowLuisHelp(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"try 'microsoft' or 'microsoft interview questions' or 'deloitte' ");
        }

        private async Task ShowLuisGreeting(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"hi.. I am praxis. You can get an insight of Technical interview questions for a given company.");
        }

    }
    
}