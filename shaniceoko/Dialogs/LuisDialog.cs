﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace shaniceoko.Dialogs
{
    [LuisModel("fadd5dcd-e56e-4498-a563-283442bd229d", "6bb9729288c2413f90ed46764f266dbd")]
    [Serializable]

    public class LuisDialog : LuisDialog<object>
    {
        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            context.Wait(MessageReceived);
        }

        [LuisIntent("AboutMe")]
        public async Task AboutMe(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"I am the best Wizard in Hogwarts");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Twice")]
        public async Task Twice(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"u has to stop!!");
            context.Wait(MessageReceived);
        }
    }
}