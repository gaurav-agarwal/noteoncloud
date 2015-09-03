﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace NoteOnCloud.Hubs
{
    public class NoteHub : Hub
    {
        public void UpdateNote(string url, string message)
        {
            Clients.AllExcept(Context.ConnectionId).updateNoteOnPage(url, message);
        }


    }

    public class NoteModel
    {
        // We declare Note as lowercase with 
        // JsonProperty to sync the client and server models
        [JsonProperty("noteText")]
        public string NoteText { get; set; }
        // We don't want the client to get the "LastUpdatedBy" property
        [JsonIgnore]
        public string URL { get; set; }
    }
}